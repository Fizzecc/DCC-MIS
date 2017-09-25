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

        public formModule2 referenceToMenu { get; set; }
        public formStockIn referenceToMain { get; set; }

        public formTransactionNew()
        {
            InitializeComponent();
            gatherProducts();
        }
        
        public formTransactionNew(string x, int z)
        {
            InitializeComponent();
            gatherProducts();

            comboBoxProducts.Enabled = false;

            comboBoxProducts.Text = x;
            textBoxProductQuantity.Text = z.ToString();
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
                                products.Add(rdr.GetInt32(0), rdr.GetString(1) + " " + rdr.GetString(3));

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
                    using (var com = new MySqlCommand("INSERT INTO inventory VALUES(null, @product_id, @brand_name, @manufacturer, @dose, @expiration_date, @batch, 'Normal')", con))
                    {
                        com.Parameters.AddWithValue("@product_id", ((KeyValuePair<int, string>)comboBoxProducts.SelectedItem).Key);
                        com.Parameters.AddWithValue("@brand_name", textBoxNameBrand.Text);
                        com.Parameters.AddWithValue("@manufacturer", textBoxManufacturer.Text);
                        string[] word = ((KeyValuePair<int, string>)comboBoxProducts.SelectedItem).Value.Split(' ');
                        com.Parameters.AddWithValue("@dose", word[1]);

                        if (word[1] == "Non-consumable")
                        {
                            com.Parameters.AddWithValue("@expiration_date", dateTimePickerDateExpiry.Value.ToString("2099-01-01"));
                        }
                        else
                        {
                            com.Parameters.AddWithValue("@expiration_date", dateTimePickerDateExpiry.Value.ToString("yyyy-MM-dd"));
                        }
                        com.Parameters.AddWithValue("@batch", textBoxBatch.Text);

                        com.ExecuteNonQuery();

                        if (!(referenceToMain == null))
                        {
                            referenceToMain.refreshTable();
                        }

                        if(!(referenceToMenu == null))
                        {
                            referenceToMenu.refreshTable();
                        }
                        
                    }
                }
                con.Close();
            }
        }

        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] word = comboBoxProducts.Text.Split(' ');

            if (word[1] == "Non-consumable")
            {
                dateTimePickerDateExpiry.Enabled = false;
            }
            else
            {
                dateTimePickerDateExpiry.Enabled = true;
            }
        }
        /*
private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
{
   using (var con = new MySqlConnection(conClass.connectionString))
   {
       con.Open();
       using (var com = new MySqlCommand("SELECT type, dosage FROM products WHERE id = @id", con))
       {
           com.Parameters.AddWithValue("@id", ((KeyValuePair<int, string>)comboBoxProducts.SelectedItem).Key);

           using (var rdr = com.ExecuteReader())
           {
               if (rdr.Read())
               {
                   if (rdr.GetString(0) == "Non-consumable")
                   {
                       comboBoxDosage.Text = "Non-consumable";
                       dateTimePickerDateExpiry.Enabled = false;
                   }
                   else
                   {
                       comboBoxDosage.Text = rdr.GetString(1);
                       dateTimePickerDateExpiry.Enabled = true;
                   }
               }
           }
       }
       con.Close();
   }
   */
    }
    }
