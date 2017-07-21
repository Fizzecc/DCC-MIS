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
    public partial class formMenu : Form
    {
        public formLogIn referenceToMain { get; set; }

        int id = -1;
        string name = "";

        public formMenu(int x, string y)
        {
            InitializeComponent();

            id = x;
            name = y;

            labelName.Text = name + "!";

            using (MySqlConnection con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand("SELECT * FROM users WHERE type = 'Patient'", con))
                {
                    MySqlDataAdapter adp = new MySqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewAppointments.DataSource = dt;
                }

                using (MySqlCommand com = new MySqlCommand("SELECT * FROM schedules", con))
                {
                    MySqlDataAdapter adp = new MySqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewSchedules.DataSource = dt;
                }
                con.Close();
            }
        }

        private void formMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            referenceToMain.Show();
            Dispose();
        }

        private void buttonSchedules_Click(object sender, EventArgs e)
        {
            formModule3 module3 = new formModule3(id);
            module3.ShowDialog();
        }

        private void buttonModule1_Click(object sender, EventArgs e)
        {
            formModule1 module1 = new formModule1(id, name);
            module1.ShowDialog();
        }

        private void buttonPatientNew_Click(object sender, EventArgs e)
        {
            formProfileNew patient = new formProfileNew(true);
            patient.ShowDialog();
        }
    }
}
