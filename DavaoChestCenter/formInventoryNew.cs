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
    public partial class formInventoryNew : Form
    {
        Dictionary<int, string> products = new Dictionary<int, string>();

        public formInventoryNew()
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

                                comboBoxProducts.DataSource = new BindingSource(products, null);
                                comboBoxProducts.DisplayMember = "Value";
                                comboBoxProducts.ValueMember = "Key";
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

        private void buttonInventoryEncode_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand("INSERT INTO inventory VALUES(null, @product_id, @product_details, @product_quantity, @expiry_date)", con))
                {
                    com.Parameters.AddWithValue("@product_id", ((KeyValuePair<int, string>)comboBoxProducts.SelectedItem).Key);
                    com.Parameters.AddWithValue("@product_details", textBoxProductDetails.Text);
                    com.Parameters.AddWithValue("@product_quantity", textBoxProductQuantity.Text);
                    com.Parameters.AddWithValue("@expiry_date", dateTimePickerDateExpiry.Value.ToString("yyyy-MM-dd"));

                    DialogResult r = MessageBox.Show("Encode product to inventory?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

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
