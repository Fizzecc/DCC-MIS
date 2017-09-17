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
                using (var com = new MySqlCommand("SELECT inventory.id, generic_name, brand_name, dosage_remaining, expiration_date, status FROM inventory INNER JOIN products ON inventory.product_id = products.id WHERE status = 'Normal'", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewInventory.DataSource = dt;

                    dataGridViewInventory.Columns["id"].Visible = false; 
                }
            }
        }

        private void dataGridViewInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var stockout = new formTransactionEdit(int.Parse(dataGridViewInventory.Rows[e.RowIndex].Cells["id"].Value.ToString()), dataGridViewInventory.Rows[e.RowIndex].Cells["brand_name"].Value.ToString());
            stockout.ShowDialog();
        }
    }
}
