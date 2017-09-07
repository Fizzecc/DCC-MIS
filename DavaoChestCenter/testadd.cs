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
    public partial class testadd : Form
    {
        public testadd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand("INSERT INTO tbl-test VALUES(null, @name, @age, @sex, @address)", con))
                {
                    com.Parameters.AddWithValue("@name", txtName.Text);
                    com.Parameters.AddWithValue("@age", txtAge.Text);
                    com.Parameters.AddWithValue("@sex", txtSex.Text);
                    com.Parameters.AddWithValue("@address", txtAddr.Text);
                    
                }
                con.Close();
            }
        }

        private void Refresh()
        {
            using (MySqlConnection con = new MySqlConnection(conClass.connectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand com = new MySqlCommand("SELECT * FROM tbl-test", con)
                    {

                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Nah!");
                    con.Close();
                }
            }
        }
    }
}
