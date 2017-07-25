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
    public partial class formProductNew : Form
    {
        public formProductNew()
        {
            InitializeComponent();
        }

        private void buttonProductEncode_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand("INSERT INTO products VALUES(null, @item_name, @item_type)", con))
                {
                    try
                    {
                        com.Parameters.AddWithValue("@item_name", textBoxProductName.Text);
                        com.Parameters.AddWithValue("@item_type", textBoxProductType.Text);

                        DialogResult r = MessageBox.Show("Encode product", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                        if (r == DialogResult.OK)
                        {
                            com.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Cancelled");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalid quantity");
                    }
                }
                con.Close();
            }
        }
    }
}
