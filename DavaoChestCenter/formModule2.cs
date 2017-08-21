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
        bool formOpenedOnce = false;

        public formModule2()
        {
            InitializeComponent();

            renew();

            formOpenedOnce = true;
        }

        public void renew()
        {
            notifExpiry();

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
                    dataGridViewProduct.DataSource = dt;
                }

                using (var com = new MySqlCommand("SELECT item_name, item_type FROM products", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewService.DataSource = dt;
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
                using (var com = new MySqlCommand("SELECT prod_id FROM products RIGHT JOIN inventory ON products.prod_id = inventory.product_id RIGHT JOIN transactions ON transactions.product_id = products.prod_id WHERE transactions.quantity > products.minrequired AND transactions.status = 'Normal'", con))
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

                    if (idProductMinimumAchievedCount == 0)
                    {
                        string command = "SELECT item_name, item_type, minrequired FROM products";

                        for (int i = 0; i < idProductMinimumAchievedCount; i++)
                        {
                            command += "prod_id != '" + idProductMinimumAchieved[i] + "' AND ";
                        }

                        command = command.TrimEnd(' '); command = command.TrimEnd('D'); command = command.TrimEnd('N'); command = command.TrimEnd('A');

                        MessageBox.Show(command);

                        using (var com2 = new MySqlCommand(command, con))
                        {
                            var adp = new MySqlDataAdapter(com2);
                            var dt = new DataTable();
                            adp.Fill(dt);
                            dataGridViewRequired.DataSource = dt;
                        }
                        if (!formOpenedOnce)
                        {
                            MessageBox.Show("There are products that are out of stock!");
                        }
                    }
                    else
                    {
                        string command = "SELECT item_name, item_type, minrequired FROM products WHERE";

                        for (int i = 0; i < idProductMinimumAchievedCount; i++)
                        {
                            command += " prod_id != '" + idProductMinimumAchieved[i] + "' AND ";
                        }

                        command = command.TrimEnd(' '); command = command.TrimEnd('D'); command = command.TrimEnd('N'); command = command.TrimEnd('A');

                        using (var com2 = new MySqlCommand(command, con))
                        {
                            var adp = new MySqlDataAdapter(com2);
                            var dt = new DataTable();
                            adp.Fill(dt);
                            dataGridViewRequired.DataSource = dt;
                        }

                        if (!formOpenedOnce)
                        {
                            MessageBox.Show("There are products that are out of stock!");
                        }
                    }
                }
                con.Close();
            }
        }

        public void notifExpiry()
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT * FROM products RIGHT JOIN inventory ON products.prod_id = inventory.product_id RIGHT JOIN transactions ON transactions.product_id = products.prod_id WHERE expiry_date >= NOW() AND expiry_date <= DATE_ADD(DATE(NOW()), INTERVAL 7 DAY) GROUP BY transaction_id", con))
                {
                    using (var rdr = com.ExecuteReader())
                    {
                        while (rdr.HasRows)
                        {
                            if (rdr.Read())
                            {
                                if (!formOpenedOnce)
                                {
                                    MessageBox.Show(rdr.GetString(1) + " will expire at " + rdr.GetString(11));
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }

                using (var com2 = new MySqlCommand("UPDATE transactions SET status = 'Expired' WHERE expiry_date <= NOW()", con))
                {
                    com2.ExecuteNonQuery();
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
            refreshTable();
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
