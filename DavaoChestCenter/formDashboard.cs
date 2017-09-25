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

                using (var com = new MySqlCommand("SELECT name, brand_name, manufacturer, inventory.dosage, expiration_date, status FROM inventory INNER JOIN products ON inventory.product_id = products.id", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewInventory.DataSource = dt;
                }
                con.Close();
            }
        }
        private void checkBoxCascade_CheckedChanged(object sender, EventArgs e)
        {
            string commandstring = "";
            if (checkBoxCascade.Checked) commandstring = "SELECT name, brand_name, manufacturer, inventory.dosage, COUNT(*) count FROM inventory INNER JOIN products ON inventory.product_id = products.id WHERE status = 'Normal' GROUP BY brand_name HAVING count > 1";
            else commandstring = "SELECT name, brand_name, manufacturer, inventory.dosage, expiration_date, status FROM inventory INNER JOIN products ON inventory.product_id = products.id";

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
