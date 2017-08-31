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
    public partial class formInventoryNew : Form
    {
        public formModule2 referenceToMain { get; set; }

        public formInventoryNew()
        {
            InitializeComponent();

            refreshTable();
        }

        public void refreshTable()
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT * FROM transactions RIGHT JOIN products ON transactions.product_id = products.prod_id WHERE processed = 'No'", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewPending.DataSource = dt;
                }
                con.Close();
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT * FROM transactions RIGHT JOIN products ON transactions.product_id = products.prod_id WHERE processed = 'No'", con))
                {
                    using (MySqlDataReader rdr = com.ExecuteReader())
                    {
                        while (rdr.HasRows)
                        {
                            if (rdr.Read())
                            {
                                using (var con2 = new MySqlConnection(conClass.connectionString))
                                {
                                    con2.Open();
                                    using (var add = new MySqlCommand("INSERT INTO inventory VALUES(null, '" + rdr.GetInt32(1) + "', '" + rdr.GetInt32(0) + "')", con2))
                                    {
                                        add.ExecuteNonQuery();
                                    }
                                    con2.Close();
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    
                    using (var upd = new MySqlCommand("UPDATE transactions SET processed='Yes' WHERE processed='No'", con))
                    {
                        upd.ExecuteNonQuery();
                    }
                }
                con.Close();
            }
            refreshTable();

            if (referenceToMain != null)
            {
                referenceToMain.renew();
            }
            else
            {
                Dispose();
            }
        }
        
    }
}
