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
    public partial class formRegistration3 : Form
    {
        public formRegistration3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("INSERT INTO users VALUES(null, @firstname, @middlename, @lastname, @username, @password, @birthdate)", con))
                {
                    com.Parameters.AddWithValue("@firstname", txtfname.Text);
                    com.Parameters.AddWithValue("@middlename", txtmname.Text);
                    com.Parameters.AddWithValue("@lastname", txtLname.Text);
                    com.Parameters.AddWithValue("@username", txtUser.Text);
                    com.Parameters.AddWithValue("@password", txtPass.Text);
                    com.Parameters.AddWithValue("@birthdate", dateTimePickerDate.Value.ToString("yyyy-MM-dd"));

                    DialogResult r = MessageBox.Show("Appointment Added", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

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

        }
    }
}
