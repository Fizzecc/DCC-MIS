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
    public partial class formLogIn : Form
    {
        public formLogIn()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            textBoxUsername.Clear();

            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Username";
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            textBoxPassword.Clear();

            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Password";
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE username = @username AND password = @password", con))
                {
                    cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            rdr.Read();
                            int id = rdr.GetInt32(0);
                            string firstname = rdr.GetString(1);
                            string lastname = rdr.GetString(3);
                            string type = rdr.GetString(8);

                            if (type.Equals("Doctor") || type.Equals("Staff"))
                            {
                                formMenu menu = new formMenu(id, (firstname + " " + lastname));
                                menu.referenceToMain = this;
                                menu.Show();
                                Hide();
                            }
                            else if (type.Equals("Patient"))
                            {
                                MessageBox.Show("You're a patient");
                                formAppointment appoint = new formAppointment(id, firstname + " " + lastname);
                                appoint.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Invalid type");
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Invalid username and/or password", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                con.Close();
            }
        }
    }

    public class conClass
    {
        // 
        public static readonly string connectionString = "Server=localhost;Port=3307;Database=chest;Uid=root;Pwd=root;";
    }
}
