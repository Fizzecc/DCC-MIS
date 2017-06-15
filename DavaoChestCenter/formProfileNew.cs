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
    public partial class formProfileNew : Form
    {
        public formProfileNew()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand("INSERT INTO users VALUES(null, @firstname, @middlename, @lastname, @username, @password, @birthdate, @sex, @type)", con)) {

                    com.Parameters.AddWithValue("@firstname", textBoxNameFirst.Text);
                    com.Parameters.AddWithValue("@middlename", textBoxNameMiddle.Text);
                    com.Parameters.AddWithValue("@lastname", textBoxNameLast.Text);
                    com.Parameters.AddWithValue("@birthdate", dateTimePickerDateBirth.Value.ToString("yyyy-MM-dd"));
                    com.Parameters.AddWithValue("@sex", comboBoxSex.Text);
                    com.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    com.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    com.Parameters.AddWithValue("@type", comboBoxType.Text);

                    DialogResult r = MessageBox.Show("Confirm action", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

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
