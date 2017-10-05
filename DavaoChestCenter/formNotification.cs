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
    public partial class formNotification : Form
    {
        public formNotification()
        {
            InitializeComponent();

            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT * FROM inventory WHERE expiration_date <= NOW() AND expiration_date <= DATE_ADD(DATE(NOW()), INTERVAL 7 DAY) AND STATUS = 'Expired'", con))
                {
                    using (var adp = new MySqlDataAdapter(com))
                    {
                        var dt = new DataTable();
                        adp.Fill(dt);
                        dataGridViewItems.DataSource = dt;
                        dt.Dispose();

                        dataGridViewItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridViewItems.AutoResizeColumns();

                        dataGridViewItems.Columns["id"].Visible = false;
                        dataGridViewItems.Columns["product_id"].Visible = false;
                        dataGridViewItems.Columns["status"].Visible = false;

                        dataGridViewItems.Columns["brand_name"].HeaderText = "Brand Name";
                        dataGridViewItems.Columns["manufacturer"].HeaderText = "Manufacturer";
                        dataGridViewItems.Columns["dosage"].HeaderText = "Dosage";
                        dataGridViewItems.Columns["expiration_date"].HeaderText = "Expiration Date";
                        dataGridViewItems.Columns["batch"].HeaderText = "Batch Number/Code";
                    }
                }
                con.Close();
            }
        }
    }
}
