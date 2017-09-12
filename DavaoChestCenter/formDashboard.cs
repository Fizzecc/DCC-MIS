using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DavaoChestCenter
{
    public partial class formDashboard : Form
    {
        public formDashboard(int x)
        {
            InitializeComponent();

            //refreshTable();

            showSchedule();
        }

        public void refreshTable()
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT firstname, middlename, lastname, schedule_days, working_time_start, working_time_end FROM users RIGHT JOIN schedules ON users.id = schedules.staff_id", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewSchedule.DataSource = dt;
                }

                using (var com = new MySqlCommand("SELECT item_name, item_type, quantity, status, expiry_date FROM products INNER JOIN inventory ON products.prod_id = inventory.product_id inner JOIN transactions ON transactions.product_id = products.prod_id GROUP BY transactions.id ORDER BY expiry_date", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewInventory.DataSource = dt;
                }
                con.Close();
            }
        }

        public void showSchedule()
        {
            foreach(DataGridViewRow row in dataGridViewSchedule.Rows)
            {
                var x = row.Cells["schedule_days"].Value.ToString();

                string[] split = x.Split('/');

                Boolean flag = false;

                foreach(string words in split)
                {
                    if (words == System.DateTime.Now.DayOfWeek.ToString())
                        flag = true;
                }

                if (flag)
                {
                    var label = new Label();

                    label.Text = row.Cells["firstname"].Value.ToString() + " " + row.Cells["lastname"].Value.ToString() + " will work at " + row.Cells["working_time_start"].Value.ToString() + " until " + row.Cells["working_time_end"].Value.ToString();

                    label.Size = new Size(600, 20);

                    flowLayoutPanelWorkers.Controls.Add(label);
                }
            }
        }
    }
}
