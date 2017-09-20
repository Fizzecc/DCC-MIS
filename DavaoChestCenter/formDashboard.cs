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

            refreshTable();

            showSchedule();
        }

        public void refreshTable()
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT firstname, middlename, lastname, schedule_days, working_time_start, working_time_end FROM staff RIGHT JOIN schedules ON staff.id = schedules.staff_id", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewSchedule.DataSource = dt;
                }

                using (var com = new MySqlCommand("SELECT generic_name, brand_name, dosage_remaining, expiration_date FROM inventory INNER JOIN products ON inventory.product_id = products.id", con))
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

                    label.Text = row.Cells["firstname"].Value.ToString() + " " + row.Cells["lastname"].Value.ToString() + " will work at " + row.Cells["working_time_start"].Value.ToString() + " until " + row.Cells["working_time_end"].Value.ToString() + " today";

                    label.Size = new Size(600, 20);

                    flowLayoutPanelWorkers.Controls.Add(label);
                }
            }
        }

        private void checkBoxCascade_CheckedChanged(object sender, EventArgs e)
        {
            string commandstring = "";
            if (checkBoxCascade.Checked) commandstring = "SELECT generic_name, brand_name, dose, COUNT(*) count FROM inventory INNER JOIN products ON inventory.product_id = products.id GROUP BY brand_name HAVING count > 1";
            else commandstring = "SELECT generic_name, brand_name, dosage_remaining, expiration_date FROM inventory INNER JOIN products ON inventory.product_id = products.id";

            using (var con = new MySqlConnection(conClass.connectionString))
            {
                using (var com = new MySqlCommand(commandstring, con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewInventory.DataSource = dt;
                }
            }
        }
    }
}
