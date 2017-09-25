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
                using (var com = new MySqlCommand("SELECT service_name, service_type, service_details, name, type FROM services INNER JOIN products on services.product_id = products.id;", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewServices.DataSource = dt;
                }
                con.Close();
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var create = new formServiceAdd();
            create.ShowDialog();
        }
    }
}
