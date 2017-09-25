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

        Dictionary<int, string> otherProducts = new Dictionary<int, string>();

        Dictionary<int, int> otherProductsQuantity = new Dictionary<int, int>();

        string otherProductsContainer = ""; string otherProductsQuantityContainer = "";

        public formServiceAdd()
        {
            InitializeComponent();
            gatherProducts();

            refreshTable();
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

                                comboBoxExtra.DataSource = new BindingSource(products, null);
                                comboBoxExtra.DisplayMember = "Value";
                                comboBoxExtra.ValueMember = "Key";
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

        public void refreshTable()
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT service_name, service_type, service_details, name, type FROM services INNER JOIN products on services.product_id = products.id;", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewInventory.DataSource = dt;
                }
                con.Close();
            }
        }

        private void buttonServiceCreate_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conClass.connectionString))
                {
                    con.Open();
                    using (MySqlCommand com = new MySqlCommand("INSERT INTO services VALUES(null, @product_id, @product_quantity, @service_name, @service_type, @service_details, @other_products_id, @other_products_quantity)", con))
                    {
                        com.Parameters.AddWithValue("@product_id", ((KeyValuePair<int, string>)comboBoxItems.SelectedItem).Key);

                        com.Parameters.AddWithValue("@product_quantity", int.Parse(textBoxQuantity.Text));

                        com.Parameters.AddWithValue("@service_name", textBoxServiceName.Text);
                        com.Parameters.AddWithValue("@service_type", textBoxServiceType.Text);
                        com.Parameters.AddWithValue("@service_details", textBoxServiceDetails.Text);
                        com.Parameters.AddWithValue("@other_products_id", otherProductsContainer);
                        com.Parameters.AddWithValue("@other_products_quantity", otherProductsQuantityContainer);

                        if (textBoxOther.Text != "")
                        {
                            for (int i = 0; i < int.Parse(textBoxOther.Text); i++)
                            {

                            }
                        }

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
            catch
            {
                MessageBox.Show("You have entered an invalid number!");
            }
        }

        private void textBoxQuantityOther_TextChanged(object sender, EventArgs e)
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
                        flowLayoutPanel.Controls.Add(combo); flowLayoutPanel.Controls.Add(text);
                    }
                }
                catch
                {
                    MessageBox.Show("You have entered an invalid number!");
                }
            }
        }
    }
}
