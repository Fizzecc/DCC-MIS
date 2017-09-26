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
    public partial class formAppointmentUpdate : Form
    {
        int selectedID = -1;
        public formAppointmentUpdate(int x, string y)
        {
            InitializeComponent();

            label1.Text = y;
            selectedID = x;
        }

        private void buttonServiceCreate_Click(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("UPDATE registration SET appointmentDate = @appointmentDate WHERE registration_id = @registration_id", con))
                {
                    com.Parameters.AddWithValue("@appointmentDate", dateTimePicker.Value.ToString("yyyy-MM-dd"));
                    com.Parameters.AddWithValue("@registration_id", selectedID);

                    com.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }
}
