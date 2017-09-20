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
        int id = -1; int selectedUser = -1; string patientName = "";
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
        }

        public void refreshTables()
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT id, firstname, middlename, lastname, username, password, schedule_days, working_time_start, working_time_end FROM staff RIGHT JOIN schedules ON staff.id = schedules.staff_id WHERE id != " + id, con))
                {
                    using (var adp = new MySqlDataAdapter(com))
                    {
                        var dt = new DataTable();
                        adp.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dt.Dispose();

                        dataGridView1.Columns["id"].Visible = false;
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

            var update = new formProfileUpdate(selectedUser, firstname, middlename, lastname, username, password, schedule_days, working_time_start, working_time_end);
            update.ShowDialog();
        }
    }
}
