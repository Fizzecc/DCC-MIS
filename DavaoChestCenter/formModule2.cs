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
                using (var com = new MySqlCommand("SELECT name, brand_name, dosage, manufacturer, expiration_date, batch, status FROM inventory INNER JOIN products ON inventory.product_id = products.id", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewInventory.DataSource = dt;
                }

                using (var com = new MySqlCommand("SELECT name, minimum_quantity FROM products", con))
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
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT name, minimum_quantity, COUNT(status) count FROM products LEFT JOIN inventory ON products.id = inventory.product_id WHERE status = 'Normal' OR status IS NULL GROUP BY name HAVING count < minimum_quantity", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewRequired.DataSource = dt;

                    using (var rdr = com.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            var stockin = new formStockIn();
                            stockin.ShowDialog();
                        }
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

        private void buttonStockOut_Click(object sender, EventArgs e)
        {
            var stockout = new formStockOut();
            stockout.ShowDialog();
        }

        private void buttonTransactionNew_Click(object sender, EventArgs e)
        {
            var transaction = new formTransactionNew();
            transaction.referenceToMenu = this;
            transaction.ShowDialog();
        }

        private void checkBoxCascade_CheckedChanged(object sender, EventArgs e)
        {
            string commandstring = "";
            if (checkBoxCascade.Checked) commandstring = "SELECT name, brand_name, manufacturer, dosage, COUNT(*) count FROM inventory INNER JOIN products ON inventory.product_id = products.id WHERE status = 'Normal' GROUP BY brand_name HAVING count > 1";
            else commandstring = "SELECT name, brand_name, manufacturer, dosage, expiration_date, batch, status FROM inventory INNER JOIN products ON inventory.product_id = products.id";

            using (var con = new MySqlConnection(conClass.connectionString))
            {
                using (var com = new MySqlCommand(commandstring, con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewInventory.DataSource = dt;
                }
            }
        }
    }
}
