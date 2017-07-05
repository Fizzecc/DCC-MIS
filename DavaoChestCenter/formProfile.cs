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
            formProfileNew profile = new formProfileNew();
            profile.ShowDialog();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            formProfileUpdate update = new formProfileUpdate();
            update.ShowDialog();
        }

        private void formModule1_Load(object sender, EventArgs e)
        {
            refreshPatients();
        }

        public void refreshPatients()
        {
            using (MySqlConnection con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand("SELECT * FROM users WHERE id != " + id, con))
                {
                    using (MySqlDataAdapter adp = new MySqlDataAdapter(com))
                    {
                        DataTable dt = new DataTable();
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
            string fn  = dataGridView1.Rows[e.RowIndex].Cells["firstname"].Value.ToString();
            string ln = dataGridView1.Rows[e.RowIndex].Cells["lastname"].Value.ToString();
            patientName = fn + " " + ln;
        }
    }
}
