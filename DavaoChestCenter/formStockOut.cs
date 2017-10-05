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
    public partial class formStockOut : Form
    {
        public formStockOut()
        {
            InitializeComponent();

            refreshTables();
        }

        public void refreshTables()
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                using (var com = new MySqlCommand("SELECT * FROM inventory WHERE status = 'Normal'", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewInventory.DataSource = dt;

                    dataGridViewInventory.Columns["id"].Visible = false;
                    dataGridViewInventory.Columns["product_id"].Visible = false;

                    dataGridViewInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewInventory.AutoResizeColumns();
                }
            }
        }

        private void dataGridViewInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var stockout = new formTransactionEdit(int.Parse(dataGridViewInventory.Rows[e.RowIndex].Cells["id"].Value.ToString()), dataGridViewInventory.Rows[e.RowIndex].Cells["brand_name"].Value.ToString(), dataGridViewInventory.Rows[e.RowIndex].Cells["dosage"].Value.ToString());
            stockout.ShowDialog();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                using (var con = new MySqlConnection(conClass.connectionString))
                {
                    using (var com = new MySqlCommand("SELECT * FROM inventory WHERE status = 'Normal' AND brand_name LIKE '%" + textBoxSearch.Text + "%' OR batch LIKE '%" + textBoxSearch.Text + "%'", con))
                    {
                        var adp = new MySqlDataAdapter(com);
                        var dt = new DataTable();
                        adp.Fill(dt);
                        dataGridViewInventory.DataSource = dt;

                        dataGridViewInventory.Columns["id"].Visible = false;
                        dataGridViewInventory.Columns["product_id"].Visible = false;
                    }
                }
            }
            else
            {
                using (var con = new MySqlConnection(conClass.connectionString))
                {
                    using (var com = new MySqlCommand("SELECT * FROM inventory WHERE status = 'Normal'", con))
                    {
                        var adp = new MySqlDataAdapter(com);
                        var dt = new DataTable();
                        adp.Fill(dt);
                        dataGridViewInventory.DataSource = dt;

                        dataGridViewInventory.Columns["id"].Visible = false;
                        dataGridViewInventory.Columns["product_id"].Visible = false;
                    }
                }
            }
           
        }
    }
}
