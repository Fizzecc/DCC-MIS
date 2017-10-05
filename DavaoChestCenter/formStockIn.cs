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
                using (var com = new MySqlCommand("SELECT name, products.dosage, minimum_quantity, SUM(CASE WHEN status = 'Normal' THEN 1 ELSE 0 END) AS Count FROM products LEFT JOIN inventory ON products.id = inventory.product_id GROUP BY name , products.dosage HAVING Count < minimum_quantity", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewInventory.DataSource = dt;

                    dataGridViewInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewInventory.AutoResizeColumns();

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

                    dataGridViewInventory.Columns["name"].HeaderText = "Name";
                    dataGridViewInventory.Columns["dosage"].HeaderText = "Dosage";
                    dataGridViewInventory.Columns["minimum_quantity"].HeaderText = "Minimum Quantity";
                }
                con.Close();
            }
        }

        private void dataGridViewRequired_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            formTransactionNew transaction = new formTransactionNew(dataGridViewInventory.Rows[e.RowIndex].Cells["name"].Value.ToString() + " " + dataGridViewInventory.Rows[e.RowIndex].Cells["dosage"].Value.ToString(), int.Parse(dataGridViewInventory.Rows[e.RowIndex].Cells["minimum_quantity"].Value.ToString()));
            transaction.referenceToMain = this;
            transaction.ShowDialog();
        }
    }
}
