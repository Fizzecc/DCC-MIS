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

            comboBoxSort.Text = "All Items";
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
                using (var com = new MySqlCommand("SELECT name, brand_name, inventory.dosage, manufacturer, expiration_date, batch, status FROM inventory INNER JOIN products ON inventory.product_id = products.id", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewInventory.DataSource = dt;
                    
                    dataGridViewInventory.BorderStyle = BorderStyle.None;
                    dataGridViewInventory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                    dataGridViewInventory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dataGridViewInventory.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
                    dataGridViewInventory.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                    dataGridViewInventory.BackgroundColor = Color.White;

                    dataGridViewInventory.EnableHeadersVisualStyles = false;
                    dataGridViewInventory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                    dataGridViewInventory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
                    dataGridViewInventory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                    dataGridViewInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewInventory.AutoResizeColumns();
                }

                using (var com = new MySqlCommand("SELECT COUNT(status) FROM inventory WHERE status = 'Normal' AND dosage != 'Non-consumable'", con))
                {
                    using (var rdr = com.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            labelNormal.Text = "Normal: " + rdr.GetInt32(0);
                        }
                    }
                }

                using (var com = new MySqlCommand("SELECT COUNT(status) FROM inventory WHERE status = 'Returned'", con))
                {
                    using (var rdr = com.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            labelReturned.Text = "Returned: " + rdr.GetInt32(0);
                        }
                    }
                }

                using (var com = new MySqlCommand("SELECT COUNT(status) FROM inventory WHERE status = 'Damaged' AND dosage != 'Non-consumable'", con))
                {
                    using (var rdr = com.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            labelDamaged.Text = "Damaged: " + rdr.GetInt32(0);
                        }
                    }
                }

                using (var com = new MySqlCommand("SELECT COUNT(status) FROM inventory WHERE status = 'Normal' AND dosage = 'Non-consumable'", con))
                {
                    using (var rdr = com.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            labelNonNormal.Text = "Normal: " + rdr.GetInt32(0);
                        }
                    }
                }

                using (var com = new MySqlCommand("SELECT COUNT(status) FROM inventory WHERE status = 'Under Repair'", con))
                {
                    using (var rdr = com.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            labelNonUnderRepair.Text = "Under Repair: " + rdr.GetInt32(0);
                        }
                    }
                }

                using (var com = new MySqlCommand("SELECT COUNT(status) FROM inventory WHERE status = 'Damaged' AND dosage = 'Non-consumable'", con))
                {
                    using (var rdr = com.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            labelNonDamaged.Text = "Damaged: " + rdr.GetInt32(0);
                        }
                    }
                }
                con.Close();
            }
        }

        public void notifMinimum()
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT name, products.dosage, minimum_quantity, SUM(CASE WHEN status = 'Normal' THEN 1 ELSE 0 END) AS count FROM products LEFT JOIN inventory ON products.id = inventory.product_id GROUP BY name , products.dosage HAVING count < minimum_quantity", con))
                {
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
            ClsPrint _ClsPrint = new ClsPrint(dataGridViewInventory, "Inventory");
            _ClsPrint.PrintForm();
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

        public string commandChange()
        {
            string command = "";

            if (checkBoxCascade.Checked)
            {
                if (textBoxSearch.Text != "")
                {
                    if (comboBoxSort.Text == "All Items")
                        command = "SELECT name, brand_name, inventory.dosage, batch, status, COUNT(*) count, minimum_quantity FROM inventory INNER JOIN products ON inventory.product_id = products.id WHERE name LIKE '%" + textBoxSearch.Text + "%' OR brand_name LIKE '%" + textBoxSearch.Text + "%' AND status = 'Normal' GROUP BY status HAVING count >= 1 ORDER BY inventory.id";
                    if (comboBoxSort.Text == "Generic Name")
                        command = "SELECT name, brand_name, inventory.dosage, batch, status, COUNT(*) count, minimum_quantity FROM inventory INNER JOIN products ON inventory.product_id = products.id WHERE name LIKE '%" + textBoxSearch.Text + "%' OR brand_name LIKE '%" + textBoxSearch.Text + "%' AND status = 'Normal' GROUP BY status HAVING count >= 1 ORDER BY name";
                    if (comboBoxSort.Text == "Brand Name")
                        command = "SELECT name, brand_name, inventory.dosage, batch, status, COUNT(*) count, minimum_quantity FROM inventory INNER JOIN products ON inventory.product_id = products.id WHERE name LIKE '%" + textBoxSearch.Text + "%' OR brand_name LIKE '%" + textBoxSearch.Text + "%' AND status = 'Normal' GROUP BY status HAVING count >= 1 ORDER BY brand_name";
                    if (comboBoxSort.Text == "Expiration Date")
                        command = "SELECT name, brand_name, inventory.dosage, batch, status, COUNT(*) count, minimum_quantity FROM inventory INNER JOIN products ON inventory.product_id = products.id WHERE name LIKE '%" + textBoxSearch.Text + "%' OR brand_name LIKE '%" + textBoxSearch.Text + "%' AND status = 'Normal' GROUP BY status HAVING count >= 1 ORDER BY expiration_date";
                }
                else
                {
                    if (comboBoxSort.Text == "All Items")
                        command = "SELECT name, brand_name, inventory.dosage, batch, status, COUNT(*) count, minimum_quantity FROM inventory INNER JOIN products ON inventory.product_id = products.id WHERE status = 'Normal' GROUP BY brand_name HAVING count >= 1 ORDER BY inventory.id";
                    if (comboBoxSort.Text == "Generic Name")
                        command = "SELECT name, brand_name, inventory.dosage, batch, status, COUNT(*) count, minimum_quantity FROM inventory INNER JOIN products ON inventory.product_id = products.id WHERE status = 'Normal' GROUP BY brand_name HAVING count >= 1 ORDER BY name";
                    if (comboBoxSort.Text == "Brand Name")
                        command = "SELECT name, brand_name, inventory.dosage, batch, status, COUNT(*) count, minimum_quantity FROM inventory INNER JOIN products ON inventory.product_id = products.id WHERE status = 'Normal' GROUP BY brand_name HAVING count >= 1 ORDER BY brand_name";
                    if (comboBoxSort.Text == "Expiration Date")
                        command = "SELECT name, brand_name, inventory.dosage, batch, status, COUNT(*) count, minimum_quantity FROM inventory INNER JOIN products ON inventory.product_id = products.id WHERE status = 'Normal' GROUP BY brand_name HAVING count >= 1 ORDER BY expiration_date";
                }
            }
            else
            {
                if (textBoxSearch.Text != "")
                {
                    if (comboBoxSort.Text == "All Items")
                        command = "SELECT name, brand_name, inventory.dosage, expiration_date, batch, status FROM inventory INNER JOIN products ON inventory.product_id = products.id WHERE name LIKE '%" + textBoxSearch.Text + "%' OR brand_name LIKE '%" + textBoxSearch.Text + "%' ORDER BY inventory.id";
                    if (comboBoxSort.Text == "Generic Name")
                        command = "SELECT name, brand_name, inventory.dosage, expiration_date, batch, status FROM inventory INNER JOIN products ON inventory.product_id = products.id WHERE name LIKE '%" + textBoxSearch.Text + "%' OR brand_name LIKE '%" + textBoxSearch.Text + "%' ORDER BY name";
                    if (comboBoxSort.Text == "Brand Name")
                        command = "SELECT name, brand_name, inventory.dosage, expiration_date, batch, status FROM inventory INNER JOIN products ON inventory.product_id = products.id WHERE name LIKE '%" + textBoxSearch.Text + "%' OR brand_name LIKE '%" + textBoxSearch.Text + "%' ORDER BY brand_name";
                    if (comboBoxSort.Text == "Expiration Date")
                        command = "SELECT name, brand_name, inventory.dosage, expiration_date, batch, status FROM inventory INNER JOIN products ON inventory.product_id = products.id WHERE name LIKE '%" + textBoxSearch.Text + "%' OR brand_name LIKE '%" + textBoxSearch.Text + "%' ORDER BY expiration_date";
                }
                else
                {
                    if (comboBoxSort.Text == "All Items")
                        command = "SELECT name, brand_name, inventory.dosage, expiration_date, batch, status FROM inventory INNER JOIN products ON inventory.product_id = products.id ORDER BY inventory.id";
                    if (comboBoxSort.Text == "Generic Name")
                        command = "SELECT name, brand_name, inventory.dosage, expiration_date, batch, status FROM inventory INNER JOIN products ON inventory.product_id = products.id ORDER BY name";
                    if (comboBoxSort.Text == "Brand Name")
                        command = "SELECT name, brand_name, inventory.dosage, expiration_date, batch, status FROM inventory INNER JOIN products ON inventory.product_id = products.id ORDER BY brand_name";
                    if (comboBoxSort.Text == "Expiration Date")
                        command = "SELECT name, brand_name, inventory.dosage, expiration_date, batch, status FROM inventory INNER JOIN products ON inventory.product_id = products.id ORDER BY expiration_date";
                }
            }

            return command;
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand(commandChange(), con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewInventory.DataSource = dt;
                    
                }
                textBoxSearch.Text = "";

                con.Close();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand(commandChange(), con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewInventory.DataSource = dt;

                }
                con.Close();
            }
        }

        private void checkBoxCascade_CheckedChanged(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand(commandChange(), con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewInventory.DataSource = dt;

                }
                con.Close();
            }
        }
        /*
private void checkBoxCascade_CheckedChanged(object sender, EventArgs e)
{
string commandstring = "";
if (checkBoxCascade.Checked) commandstring = "SELECT name, brand_name, manufacturer, dosage, COUNT(*) count FROM inventory INNER JOIN products ON inventory.product_id = products.id WHERE status = 'Normal' GROUP BY brand_name HAVING count >= 1";
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
}*/
    }
}
