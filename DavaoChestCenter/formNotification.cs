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

                        dataGridViewItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridViewItems.AutoResizeColumns();
                        dataGridViewItems.AllowUserToResizeColumns = true;
                        dataGridViewItems.AllowUserToOrderColumns = true;

                        dt.Dispose();

                        dataGridViewItems.Columns["id"].Visible = false;
                        dataGridViewItems.Columns["product_id"].Visible = false;

                    }
                }
                con.Close();
            }
        }
    }
}
