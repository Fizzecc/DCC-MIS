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
    public partial class formStockIn : Form
    {
        public formModule2 referenceToMain { get; set; }

        public formStockIn()
        {
            InitializeComponent();
            refreshTable();
        }

        public void refreshTable()
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

                    if (idProductMinimumAchievedCount == 0)
                    {
                        string command = "SELECT item_name, item_type, minrequired FROM products";

                        using (var com2 = new MySqlCommand(command, con))
                        {
                            var adp = new MySqlDataAdapter(com2);
                            var dt = new DataTable();
                            adp.Fill(dt);
                            dataGridViewRequired.DataSource = dt;
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
                    }
                }
                con.Close();
            }
        }

        private void dataGridViewRequired_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            formTransactionNew transaction = new formTransactionNew(dataGridViewRequired.Rows[e.RowIndex].Cells["item_name"].Value.ToString(), int.Parse(dataGridViewRequired.Rows[e.RowIndex].Cells["minrequired"].Value.ToString()));
            transaction.referenceToMain = this;
            transaction.ShowDialog();
        }
    }
}
