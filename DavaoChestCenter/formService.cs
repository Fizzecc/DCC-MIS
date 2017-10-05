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
    public partial class formService : Form
    {
        int selectedService = -1;

        public formService()
        {
            InitializeComponent();

            refreshTable();
        }

        public void refreshTable()
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT service_id, service_name, service_type, service_details, name, type, product_quantity, products.dosage, other_products_id, other_products_quantity, price FROM services INNER JOIN products on services.product_id = products.id;", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewServices.DataSource = dt;

                    dataGridViewServices.Columns["service_id"].Visible = false;
                    dataGridViewServices.Columns["other_products_id"].Visible = false;
                    dataGridViewServices.Columns["other_products_quantity"].Visible = false;

                    dataGridViewServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewServices.AutoResizeColumns();
                }

                using (var com = new MySqlCommand("SELECT service_name, service_type, name, type, product_quantity, products.dosage, price FROM services INNER JOIN products on services.product_id = products.id;", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewContainer.DataSource = dt;

                    dataGridViewContainer.Visible = false;
                }
                con.Close();
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var create = new formServiceAdd();
            create.referenceToMain = this;
            create.ShowDialog();
        }

        private void dataGridViewServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedService = int.Parse(dataGridViewServices.Rows[e.RowIndex].Cells["service_id"].Value.ToString());
            string name = dataGridViewServices.Rows[e.RowIndex].Cells["service_name"].Value.ToString();
            string type = dataGridViewServices.Rows[e.RowIndex].Cells["type"].Value.ToString();
            string details = dataGridViewServices.Rows[e.RowIndex].Cells["service_details"].Value.ToString();
            string product = dataGridViewServices.Rows[e.RowIndex].Cells["name"].Value.ToString() + " " + dataGridViewServices.Rows[e.RowIndex].Cells["dosage"].Value.ToString();
            string quantity = dataGridViewServices.Rows[e.RowIndex].Cells["product_quantity"].Value.ToString();
            string other_products = dataGridViewServices.Rows[e.RowIndex].Cells["other_products_id"].Value.ToString();
            string other_products_quantity = dataGridViewServices.Rows[e.RowIndex].Cells["other_products_quantity"].Value.ToString();
            string price = dataGridViewServices.Rows[e.RowIndex].Cells["price"].Value.ToString();

            var edit = new formServiceEdit(selectedService, name, type, details, product, quantity, other_products, other_products_quantity, price);
            edit.referenceToMain = this;
            edit.ShowDialog();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            ClsPrint _ClsPrint = new ClsPrint(dataGridViewContainer, "Services");
            _ClsPrint.PrintForm();
        }
    }
}
