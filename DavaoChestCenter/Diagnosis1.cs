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
    public partial class Diagnosis1 : Form
    {
        public Diagnosis1()
        {
            InitializeComponent();
        }

        private void testing1_Load(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT * FROM registration", con))
                {
                    using (var adp = new MySqlDataAdapter(com))
                    {
                        var dt = new DataTable();
                        adp.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dt.Dispose();

                        dataGridView1.Columns["registration_id"].Visible = false;
                    }
                }
                con.Close();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Form diag = new Diagnosis2();
            diag.Show();
            /*
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("UPDATE registration SET patient_Lname = @patient_Lname WHERE registration_id = @registration_id", con))
                {
                    //com.Parameters.AddWithValue("@registration_id", txtID.Text);
                    //com.Parameters.AddWithValue("@patient_Lname", txtLname.Text);


                    DialogResult r = MessageBox.Show("Mark appointment as done?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    
                    if (r == DialogResult.OK)
                    {
                        com.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Cancelled");
                    }
                    
                }
                con.Close();
               

            }
            */
        }

        private void btn_Click(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();

                using (var com = new MySqlCommand("SELECT * FROM registration", con))
                {
                    using (var adp = new MySqlDataAdapter(com))
                    {
                        var dt = new DataTable();
                        adp.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dt.Dispose();

                        dataGridView1.Columns["registration_id"].Visible = false;
                    }
                }
                con.Close();
            }
        }
    }
}
