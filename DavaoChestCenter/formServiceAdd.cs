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
    public partial class formServiceAdd : Form
    {
        Dictionary<int, string> products = new Dictionary<int, string>();

        public formServiceAdd()
        {
            InitializeComponent();
            gatherProducts();
        }

        private void gatherProducts()
        {
            using (MySqlConnection con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand("SELECT * FROM products", con))
                {
                    using (MySqlDataReader rdr = com.ExecuteReader())
                    {
                        while (rdr.HasRows)
                        {
                            if (rdr.Read())
                            {
                                products.Add(rdr.GetInt32(0), rdr.GetString(1));

                                comboBoxItems.DataSource = new BindingSource(products, null);
                                comboBoxItems.DisplayMember = "Value";
                                comboBoxItems.ValueMember = "Key";
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
                con.Close();
            }
        }

        private void buttonServiceCreate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand("INSERT INTO services VALUES(null, @item_id, @service_name, @service_type, @service_details)", con))
                {
                    com.Parameters.AddWithValue("@item_id", ((KeyValuePair<int, string>)comboBoxItems.SelectedItem).Key);
                    com.Parameters.AddWithValue("@service_name", textBoxServiceName.Text);
                    com.Parameters.AddWithValue("@service_type", textBoxServiceType.Text);
                    com.Parameters.AddWithValue("@service_details", textBoxServiceDetails.Text);

                    DialogResult r = MessageBox.Show("Create service", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

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
