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
        public formStockIn referenceToMain { get; set; }

        public formTransactionNew()
        {
            InitializeComponent();
            gatherProducts();
        }
        
        public formTransactionNew(string x, int y)
        {
            InitializeComponent();
            gatherProducts();

            comboBoxProducts.Text = x;
            textBoxProductQuantity.Text = y.ToString();
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

                for (int i = 0; i < int.Parse(textBoxProductQuantity.Text); i++)
                {
                    using (var com = new MySqlCommand("INSERT INTO inventory VALUES(null, @product_id, @brand_name, @dosage_remaining, @expiration_date)", con))
                    {
                        com.Parameters.AddWithValue("@product_id", ((KeyValuePair<int, string>)comboBoxProducts.SelectedItem).Key);
                        com.Parameters.AddWithValue("@brand_name", textBoxNameBrand.Text);
                        com.Parameters.AddWithValue("@dosage_remaining", int.Parse(textBoxProductDose.Text) + "/" + comboBoxDoseType.Text);
                        com.Parameters.AddWithValue("@expiration_date", dateTimePickerDateExpiry.Value.ToString("yyyy-MM-dd"));
                        
                        com.ExecuteNonQuery();

                        if (!(referenceToMain == null))
                        {
                            referenceToMain.refreshTable();
                        }
                        
                    }
                }
                con.Close();
            }
        }
    }
}
