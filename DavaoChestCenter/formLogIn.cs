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
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT * FROM staff WHERE username = @username AND password = @password", con))
                {
                    com.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    com.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    
                    using (var rdr = com.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            rdr.Read();
                            int id = rdr.GetInt32(0);
                            string firstname = rdr.GetString(1);
                            string lastname = rdr.GetString(3);
                            
                            formMenu menu = new formMenu(id, (firstname + " " + lastname));
                            menu.referenceToMain = this;
                            menu.Show();
                            Hide();
                            
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

        private void formLogIn_Load(object sender, EventArgs e)
        {

        }
    }

    public class conClass
    {
        public static readonly string connectionString = "Server=localhost;Port=3306;Database=chest;Uid=root;Pwd=root;";
    }
}
