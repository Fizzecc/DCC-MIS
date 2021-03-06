﻿using System;
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
    public partial class formServiceEdit : Form
    {
        public formService referenceToMain { get; set; }

        Dictionary<int, string> products = new Dictionary<int, string>();

        Dictionary<int, string> otherProducts = new Dictionary<int, string>();

        Dictionary<int, int> otherProductsQuantity = new Dictionary<int, int>();

        string otherProductsContainer = ""; string otherProductsQuantityContainer = "";

        int selectedService = -1;

        public formServiceEdit()
        {
            InitializeComponent();
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
                                products.Add(rdr.GetInt32(0), rdr.GetString(1) + " " + rdr.GetString(3));

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

        public formServiceEdit(int id, 
            string name, string type, string details,
            string product, string quantity,
            string other_products, string other_products_quantity,
            string price)
        {
            InitializeComponent();
            
            gatherProducts();

            selectedService = id;
            textBoxServiceName.Text = name;
            textBoxServiceType.Text = type;
            textBoxServiceDetails.Text = details;
            comboBoxItems.Text = product;
            textBoxQuantity.Text = quantity;
            otherProductsContainer = other_products;
            otherProductsQuantityContainer = other_products_quantity;
            textBoxPrice.Text = price;

            textBoxOther.Text = otherProductsContainer.Split('/').Length.ToString();

        }

        private void textBoxOther_TextChanged(object sender, EventArgs e)
        {
            otherProducts.Clear(); otherProductsQuantity.Clear();
            otherProductsContainer = ""; otherProductsQuantityContainer = "";

            flowLayoutPanel.Controls.Clear();

            if (textBoxOther.Text != "")
            {
                try
                {
                    for (int i = 0; i < int.Parse(textBoxOther.Text); i++)
                    {
                        var combo = new ComboBox(); var text = new TextBox();
                        combo.Size = new Size(220, 27); text.Size = new Size(41, 27);
                        combo.DropDownStyle = ComboBoxStyle.DropDownList;


                        combo.Name = "comboBox " + i; text.Name = "textBox " + i;

                        combo.DataSource = new BindingSource(products, null);
                        combo.DisplayMember = "Value";
                        combo.ValueMember = "Key";

                        combo.SelectedIndexChanged += (o, ea) => {
                            string[] tokens = combo.Name.Split(' ');

                            if (otherProducts.ContainsKey(int.Parse(tokens[1])))
                            {
                                otherProducts[int.Parse(tokens[1])] = combo.Text;
                            }
                            else
                            {
                                otherProducts.Add(int.Parse(tokens[1]), combo.Text);
                            }

                            otherProductsContainer = "";

                            foreach (var kvp in otherProducts)
                            {
                                var match = products.Where(p => p.Value == kvp.Value).Select(p => p.Key);

                                foreach (var key in match)
                                    otherProductsContainer += key + "/";
                            }
                            otherProductsContainer = otherProductsContainer.TrimEnd('/');
                        };

                        text.TextChanged += (o, ea) => {
                            try
                            {
                                string[] tokens = text.Name.Split(' ');

                                if (otherProductsQuantity.ContainsKey(int.Parse(tokens[1])))
                                {
                                    otherProductsQuantity[int.Parse(tokens[1])] = int.Parse(text.Text);
                                }
                                else
                                {
                                    otherProductsQuantity.Add(int.Parse(tokens[1]), int.Parse(text.Text));
                                }

                                otherProductsQuantityContainer = "";

                                foreach (var kvp in otherProductsQuantity)
                                {
                                    otherProductsQuantityContainer += kvp.Value.ToString() + "/";
                                }

                                otherProductsQuantityContainer = otherProductsQuantityContainer.TrimEnd('/');
                            }
                            catch
                            {
                                MessageBox.Show("You have entered an invalid number!");
                            }

                        };
                        text.Text = "1";

                        flowLayoutPanel.Controls.Add(combo); flowLayoutPanel.Controls.Add(text);
                    }
                }
                catch
                {
                    MessageBox.Show("You have entered an invalid number!");
                }
            }
        }

        private void buttonServiceCreate_Click(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("UPDATE services SET product_id = @product_id, product_quantity = @product_quantity, service_name = @service_name, service_type = @service_type, service_details = @service_details, other_products_id = @other_products_id, other_products_quantity = @other_products_quantity, price = @price WHERE service_id = @service_id", con))
                {
                    com.Parameters.AddWithValue("@service_id", selectedService);

                    com.Parameters.AddWithValue("@product_id", ((KeyValuePair<int, string>)comboBoxItems.SelectedItem).Key);

                    com.Parameters.AddWithValue("@product_quantity", int.Parse(textBoxQuantity.Text));

                    com.Parameters.AddWithValue("@service_name", textBoxServiceName.Text);
                    com.Parameters.AddWithValue("@service_type", textBoxServiceType.Text);
                    com.Parameters.AddWithValue("@service_details", textBoxServiceDetails.Text);
                    com.Parameters.AddWithValue("@other_products_id", otherProductsContainer);
                    com.Parameters.AddWithValue("@other_products_quantity", otherProductsQuantityContainer);

                    com.Parameters.AddWithValue("@price", textBoxPrice.Text);

                    com.ExecuteNonQuery();
                }
                con.Close();
            }
            referenceToMain.refreshTable();
        }
    }
}
