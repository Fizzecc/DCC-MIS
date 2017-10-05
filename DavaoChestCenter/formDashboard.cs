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

                    dataGridViewSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewSchedule.AutoResizeColumns();
                    
                    dataGridViewSchedule.Columns["firstname"].HeaderText = "First Name";
                    dataGridViewSchedule.Columns["middlename"].HeaderText = "Middle Name";
                    dataGridViewSchedule.Columns["lastname"].HeaderText = "Last Name";
                    dataGridViewSchedule.Columns["schedule_days"].HeaderText = "Working Days";
                    dataGridViewSchedule.Columns["working_time_start"].HeaderText = "Check In";
                    dataGridViewSchedule.Columns["working_time_end"].HeaderText = "Check Out";
                    
                    dataGridViewSchedule.BorderStyle = BorderStyle.None;
                    dataGridViewSchedule.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                    dataGridViewSchedule.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dataGridViewSchedule.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
                    dataGridViewSchedule.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                    dataGridViewSchedule.BackgroundColor = Color.White;

                    dataGridViewSchedule.EnableHeadersVisualStyles = false;
                    dataGridViewSchedule.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                    dataGridViewSchedule.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
                    dataGridViewSchedule.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                }

                using (var com = new MySqlCommand("SELECT name, brand_name, manufacturer, inventory.dosage, expiration_date, status FROM inventory INNER JOIN products ON inventory.product_id = products.id", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewInventory.DataSource = dt;
                    
                    dataGridViewInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewInventory.AutoResizeColumns();

                    dataGridViewInventory.BorderStyle = BorderStyle.None;
                    dataGridViewInventory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                    dataGridViewInventory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dataGridViewInventory.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
                    dataGridViewInventory.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                    dataGridViewInventory.BackgroundColor = Color.White;

                    dataGridViewInventory.EnableHeadersVisualStyles = false;
                    dataGridViewInventory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                    dataGridViewInventory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
                    dataGridViewInventory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
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
