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
        public formModule2 referenceToMain { get; set; }

        public formProductNew()
        {
            InitializeComponent();
        }

        private void buttonProductEncode_Click(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("INSERT INTO products VALUES(null, @item_name, @item_type, @minrequired)", con))
                {
                    try
                    {
                        com.Parameters.AddWithValue("@item_name", textBoxProductName.Text);
                        com.Parameters.AddWithValue("@item_type", textBoxProductType.Text);
                        com.Parameters.AddWithValue("@minrequired", int.Parse(textBoxProductMinimum.Text));

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
            referenceToMain.renew();
        }
    }
}
