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
    public partial class formModule2 : Form
    {
        public formModule2()
        {
            InitializeComponent();

            renew();
        }

        public void renew()
        {
            notifMinimum();

            refreshTable();
        }

        public void refreshTable()
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT item_name, item_type, quantity, status, expiry_date FROM products INNER JOIN inventory ON products.prod_id = inventory.product_id inner JOIN transactions ON transactions.product_id = products.prod_id GROUP BY transactions.id ORDER BY expiry_date", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewInventory.DataSource = dt;
                }

                using (var com = new MySqlCommand("SELECT item_name, item_type FROM products", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewProduct.DataSource = dt;
                }
                con.Close();
            }
        }

        public void notifMinimum()
        {
            int idProductMinimumAchievedCount = 0;
            
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT prod_id FROM products RIGHT JOIN inventory ON products.prod_id = inventory.product_id RIGHT JOIN transactions ON transactions.product_id = products.prod_id WHERE transactions.quantity >= products.minrequired AND transactions.status = 'Normal'", con))
                {
                    using (var rdr = com.ExecuteReader())
                    {
                        while (rdr.HasRows)
                        {
                            if (rdr.Read())
                            {
                                idProductMinimumAchievedCount++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    
                    int[] idProductMinimumAchieved = new int[idProductMinimumAchievedCount];

                    using (var rdr2 = com.ExecuteReader())
                    {
                        int count = 0;

                        while (rdr2.HasRows)
                        {
                            if (rdr2.Read())
                            {
                                idProductMinimumAchieved[count] = rdr2.GetInt32(0);

                                count++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    string command;
                    if (idProductMinimumAchievedCount == 0)
                    {
                        command = "SELECT item_name, item_type, minrequired FROM products";
                    }
                    else
                    {
                        command = "SELECT item_name, item_type, minrequired FROM products WHERE";

                        for (int i = 0; i < idProductMinimumAchievedCount; i++)
                        {
                            command += " prod_id != '" + idProductMinimumAchieved[i] + "' AND ";
                        }
                        command = command.TrimEnd(' '); command = command.TrimEnd('D'); command = command.TrimEnd('N'); command = command.TrimEnd('A');
                    }

                    using (var com2 = new MySqlCommand(command, con))
                    {
                        var adp = new MySqlDataAdapter(com2);
                        var dt = new DataTable();
                        adp.Fill(dt);
                        dataGridViewRequired.DataSource = dt;
                    }

                    if (dataGridViewRequired.Rows.Count.ToString() != "0")
                    {
                        formStockIn stockin = new formStockIn();
                        stockin.referenceToMain = this;
                        stockin.ShowDialog();
                    }
                }
                con.Close();
            }
        }

        private void buttonProductNew_Click(object sender, EventArgs e)
        {
            var product = new formProductNew();
            product.referenceToMain = this;
            product.ShowDialog();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            renew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var service = new formServiceAdd();
            service.ShowDialog();
        }

        private void buttonInventoryNew_Click(object sender, EventArgs e)
        {
            var transaction = new formTransactionNew();
            transaction.ShowDialog();
        }

        private void buttonInventoryNew_Click_1(object sender, EventArgs e)
        {
            var inventory = new formInventoryNew();
            inventory.referenceToMain = this;
            inventory.ShowDialog();
        }
    }
}
