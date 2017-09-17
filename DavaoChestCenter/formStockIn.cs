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
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT generic_name, dose, COUNT(*) count, minimum_quantity FROM products LEFT JOIN inventory ON products.id = inventory.product_id GROUP BY generic_name HAVING count < minimum_quantity", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewInventory.DataSource = dt;
                }
                con.Close();
            }
        }

        private void dataGridViewRequired_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            formTransactionNew transaction = new formTransactionNew(dataGridViewInventory.Rows[e.RowIndex].Cells["generic_name"].Value.ToString(), dataGridViewInventory.Rows[e.RowIndex].Cells["dose"].Value.ToString(), int.Parse(dataGridViewInventory.Rows[e.RowIndex].Cells["minimum_quantity"].Value.ToString()));
            transaction.referenceToMain = this;
            transaction.ShowDialog();
        }
    }
}
