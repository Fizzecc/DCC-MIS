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

            refreshTable();
        }

        public void refreshTable()
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT * FROM users WHERE type = 'Patient'", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewAppointments.DataSource = dt;
                }

                using (var com = new MySqlCommand("SELECT firstname, middlename, lastname, schedule_days, working_time_start, working_time_end FROM users RIGHT JOIN schedules ON users.id = schedules.staff_id", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
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
            var module3 = new formModule3(id);
            module3.ShowDialog();
        }

        private void buttonModule1_Click(object sender, EventArgs e)
        {
            var module1 = new formModule1(id, name);
            module1.ShowDialog();
        }

        private void buttonPatientNew_Click(object sender, EventArgs e)
        {
            var patient = new formProfileNew(true);
            patient.ShowDialog();
        }

        private void buttonModule2_Click(object sender, EventArgs e)
        {
            var module2 = new formModule2();
            module2.ShowDialog();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void buttonProductNew_Click(object sender, EventArgs e)
        {
            var product = new formProductNew();
            product.ShowDialog();
        }
    }
}
