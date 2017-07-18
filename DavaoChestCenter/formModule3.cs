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
    public partial class formModule3 : Form
    {
        public formModule3(int x)
        {
            InitializeComponent();

            using (MySqlConnection con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand("SELECT firstname, middlename, lastname, schedule_days, working_time_start, working_time_end FROM users RIGHT JOIN schedule ON users.id = schedule.staff_id", con))
                {
                    MySqlDataAdapter adp = new MySqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                con.Close();
            }
        }
    }
}
