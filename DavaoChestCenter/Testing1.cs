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
    public partial class Testing1 : Form
    {
        public Testing1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT * FROM users", con))
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
            txtfname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtmname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtlname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtUser.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtPass.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            txtBirth.Text = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            txtsex.Text = dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
            txtType.Text = dataGridView1.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
        }
    }
}
