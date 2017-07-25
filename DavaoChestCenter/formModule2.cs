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

            refreshTable();
        }

        public void refreshTable()
        {
            using (MySqlConnection con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand("SELECT item_name, product_details, product_quantity, expiry_date FROM products RIGHT JOIN inventory ON products.prod_id = inventory.product_id", con))
                {
                    MySqlDataAdapter adp = new MySqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewProduct.DataSource = dt;
                }

                using (MySqlCommand com = new MySqlCommand("SELECT service_name, item_name, service_type, service_details FROM services INNER JOIN products ON services.product_id = products.prod_id", con))
                {
                    MySqlDataAdapter adp = new MySqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewService.DataSource = dt;
                }
                con.Close();
            }
        }

        private void buttonProductNew_Click(object sender, EventArgs e)
        {
            formProductNew product = new formProductNew();
            product.ShowDialog();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formServiceAdd service = new formServiceAdd();
            service.ShowDialog();
        }

        private void buttonInventoryNew_Click(object sender, EventArgs e)
        {
            formInventoryNew inventory = new formInventoryNew();
            inventory.ShowDialog();
        }
    }
}
