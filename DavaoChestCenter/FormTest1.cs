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
    public partial class formTest1 : Form
    {

        int selectedid;
        public formTest1()
        {
            InitializeComponent();
        }

        private void test1_Load(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();

                using (var com = new MySqlCommand("SELECT * FROM staff", con))
                {
                    using (var adp = new MySqlDataAdapter(com))
                    {
                        var dt = new DataTable();
                        adp.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dt.Dispose();

                        //dataGridView1.Columns["_id"].Visible = false;
                    }
                }
                con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            string firstname = dataGridView1.Rows[e.RowIndex].Cells["firstname"].Value.ToString();
            string middlename = dataGridView1.Rows[e.RowIndex].Cells["middlename"].Value.ToString();
            string lastname = dataGridView1.Rows[e.RowIndex].Cells["lastname"].Value.ToString();
            string username = dataGridView1.Rows[e.RowIndex].Cells["username"].Value.ToString();
            string password = dataGridView1.Rows[e.RowIndex].Cells["password"].Value.ToString();

            var update = new formTest2(selectedid, firstname, middlename, lastname, username, password);
            update.ref_To_Main = this;
            update.ShowDialog();
        }
    }
}
