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
    public partial class formProfile : Form
    {
        int id = -1; int selectedUser = -1;
        string name = "";

        public formProfile(int x, string y)
        {
            InitializeComponent();

            id = x;
            name = y;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var profile = new formProfileNew();
            profile.referenceToMain = this;
            profile.ShowDialog();
        }

        private void formModule1_Load(object sender, EventArgs e)
        {
            refreshTables();
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        public void refreshTables()
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT id, firstname, middlename, lastname, username, password, schedule_days, working_time_start, working_time_end, address, contact FROM staff RIGHT JOIN schedules ON staff.id = schedules.staff_id WHERE id != " + id, con))
                {
                    using (var adp = new MySqlDataAdapter(com))
                    {
                        var dt = new DataTable();
                        adp.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dt.Dispose();

                        dataGridView1.Columns["id"].Visible = false;
                        dataGridView1.Columns["firstname"].HeaderText = "First Name";
                        dataGridView1.Columns["middlename"].HeaderText = "Middle Name";
                        dataGridView1.Columns["lastname"].HeaderText = "Last Name";
                        dataGridView1.Columns["username"].HeaderText = "Username";
                        dataGridView1.Columns["password"].HeaderText = "Password";
                        dataGridView1.Columns["schedule_days"].HeaderText = "Schedule Days";
                        dataGridView1.Columns["working_time_start"].HeaderText = "Start Working Time";
                        dataGridView1.Columns["working_time_end"].HeaderText = "End Working Time";
                        dataGridView1.Columns["address"].HeaderText = "address";
                        dataGridView1.Columns["contact"].HeaderText = "contact";
                    }
                }
                con.Close();
            }
        }
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedUser = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            string firstname = dataGridView1.Rows[e.RowIndex].Cells["firstname"].Value.ToString();
            string middlename = dataGridView1.Rows[e.RowIndex].Cells["middlename"].Value.ToString();
            string lastname = dataGridView1.Rows[e.RowIndex].Cells["lastname"].Value.ToString();
            string username = dataGridView1.Rows[e.RowIndex].Cells["username"].Value.ToString();
            string password = dataGridView1.Rows[e.RowIndex].Cells["password"].Value.ToString();
            string schedule_days = dataGridView1.Rows[e.RowIndex].Cells["schedule_days"].Value.ToString();
            string working_time_start = dataGridView1.Rows[e.RowIndex].Cells["working_time_start"].Value.ToString();
            string working_time_end = dataGridView1.Rows[e.RowIndex].Cells["working_time_end"].Value.ToString();
            string address = dataGridView1.Rows[e.RowIndex].Cells["address"].Value.ToString();
            string contact = dataGridView1.Rows[e.RowIndex].Cells["contact"].Value.ToString();

            var update = new formProfileUpdate(selectedUser, firstname, middlename, lastname, username, password, schedule_days, working_time_start, working_time_end, address, contact);
            update.referenceToMain = this;
            update.ShowDialog();
        }
    }
}
