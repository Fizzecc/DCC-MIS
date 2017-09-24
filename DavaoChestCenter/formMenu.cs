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
        public Form form;

        public formLogIn referenceToMain { get; set; }

        int id = -1;
        string name = "";

        public formMenu(int x, string y)
        {
            InitializeComponent();

            flowLayoutPanelModule1.Visible = false;

            id = x;
            name = y;

            autoExpire();
        }

        public void autoExpire()
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                /*
                using (var com = new MySqlCommand("SELECT * FROM inventory WHERE expiration_date >= NOW() AND expiration_date <= DATE_ADD(DATE(NOW()), INTERVAL 7 DAY) AND STATUS = 'Normal'", con))
                {
                    using (var rdr = com.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            MessageBox.Show("There are items that will expire a week from now!", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                */

                using (var com2 = new MySqlCommand("UPDATE inventory SET status = 'Expired' WHERE expiration_date <= NOW() AND expiration_date IS NOT NULL", con))
                {
                    com2.ExecuteNonQuery();

                    using (var com3 = new MySqlCommand("SELECT * FROM inventory WHERE expiration_date <= NOW() AND expiration_date <= DATE_ADD(DATE(NOW()), INTERVAL 7 DAY) AND STATUS = 'Expired'", con))
                    {
                        using (var rdr = com3.ExecuteReader())
                        {
                            if (rdr.HasRows)
                            {
                                var notify = new formNotification();
                                notify.ShowDialog();
                            }
                        }
                    }
                }
                con.Close();
            }
        }

        private void formMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            referenceToMain.Show();
            Dispose();
        }

        private void buttonProductNew_Click(object sender, EventArgs e)
        {
            var product = new formProductNew();
            product.ShowDialog();
        }

        private void buttonAppointment_Click(object sender, EventArgs e)
        {
            var appointment = new formAppointment(id);
            appointment.ShowDialog();

        }

        private void buttonModule2_Click_1(object sender, EventArgs e)
        {
            var module2 = new formModule2();
            showForm(module2);
        }

        private void buttonModule1_Click(object sender, EventArgs e)
        {
              if (!flowLayoutPanelModule1.Visible)
            {
                flowLayoutPanelModule1.Visible = true;
            }
            else
            {
                flowLayoutPanelModule1.Visible = false;
            }
        }

        public void showForm(Form x)
        {
            if (form != null)
            {
                form.Dispose();

                form = x;
                form.TopLevel = false;
                panelForm.Controls.Add(form);
                form.Show();
            }
            else
            {
                form = x;
                form.TopLevel = false;
                panelForm.Controls.Add(form);
                form.Show();
            }
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            var profile = new formProfile(id, name);
            showForm(profile);
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            var dashboard = new formDashboard(id);
            showForm(dashboard);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var appointment = new formAppointment(id);
            showForm(appointment);
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form test = new Diagnosis1();
            test.Show();
        }

        private void buttonModule3_Click(object sender, EventArgs e)
        {
            var module3 = new formModule3();
            showForm(module3);
        }
    }
}
