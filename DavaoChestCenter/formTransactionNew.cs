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
    public partial class formTransactionNew : Form
    {
        Dictionary<int, string> products = new Dictionary<int, string>();

        public formTransactionNew()
        {
            InitializeComponent();
            gatherProducts();
        }

        private void gatherProducts()
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT * FROM products", con))
                {
                    using (var rdr = com.ExecuteReader())
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
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("INSERT INTO transactions VALUES(null, @product_id, @quantity, @status, @expiry_date, 'No')", con))
                {
                    com.Parameters.AddWithValue("@product_id", ((KeyValuePair<int, string>)comboBoxProducts.SelectedItem).Key);
                    com.Parameters.AddWithValue("@status", comboBoxProductStatus.Text);
                    com.Parameters.AddWithValue("@quantity", textBoxProductQuantity.Text);
                    com.Parameters.AddWithValue("@expiry_date", dateTimePickerDateExpiry.Value.ToString("yyyy-MM-dd"));

                    DialogResult r = MessageBox.Show("Encode transaction?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

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
