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
                using (var com = new MySqlCommand("SELECT transactions.id, item_name, item_type, quantity, status, expiry_date FROM products INNER JOIN inventory ON products.prod_id = inventory.product_id inner JOIN transactions ON transactions.product_id = products.prod_id  WHERE status = 'Normal' GROUP BY transactions.id", con))
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
            formTransactionEdit transaction = new formTransactionEdit(int.Parse(dataGridViewInventory.Rows[e.RowIndex].Cells["id"].Value.ToString()), dataGridViewInventory.Rows[e.RowIndex].Cells["item_name"].Value.ToString());
            transaction.ShowDialog();
        }
    }
}
