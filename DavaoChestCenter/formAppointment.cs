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
    public partial class formAppointment : Form
    {
        int id = -1; int patient = -1;

        public formAppointment(int x, string y)
        {
            InitializeComponent();

            patient = x;

            refreshAppointment();

            labelName.Text = y;
            
        }
        
        public void refreshAppointment()
        {
            using (MySqlConnection con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand("SELECT * FROM appointments WHERE patient = @patient", con))
                {
                    com.Parameters.AddWithValue("@patient", patient);

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

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            formRegistration1 registration = new formRegistration1();
            registration.ShowDialog();
        }
    }
}
