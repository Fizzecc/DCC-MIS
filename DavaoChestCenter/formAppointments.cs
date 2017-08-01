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
    public partial class formAppointments : Form
    {
        Dictionary<int, string> services = new Dictionary<int, string>();

        int id = -1; int selectedUser = -1;

        public formAppointments(int x)
        {
            InitializeComponent();

            id = x;

            refreshTables();

            gatherServices();
        }
        
        public void refreshTables()
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT * FROM appointmentv", con))
                {
                    using (var adp = new MySqlDataAdapter(com))
                    {
                        var dt = new DataTable();
                        adp.Fill(dt);
                        dataGridViewAppointments.DataSource = dt;
                        dt.Dispose();
                    }
                }

                using (var com = new MySqlCommand("SELECT * FROM users WHERE type = 'Patient'", con))
                {
                    using (var adp = new MySqlDataAdapter(com))
                    {
                        var dt = new DataTable();
                        adp.Fill(dt);
                        dataGridViewPatients.DataSource = dt;
                        dt.Dispose();
                        
                        dataGridViewPatients.Columns["id"].Visible = false;
                    }
                }
                con.Close();
            }
        }

        private void gatherServices()
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT * FROM services", con))
                {
                    using (var rdr = com.ExecuteReader())
                    {
                        while (rdr.HasRows)
                        {
                            if (rdr.Read())
                            {
                                services.Add(rdr.GetInt32(0), rdr.GetString(2));

                                comboBoxServices.DataSource = new BindingSource(services, null);
                                comboBoxServices.DisplayMember = "Value";
                                comboBoxServices.ValueMember = "Key";
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
                con.Close();
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("INSERT INTO appointments VALUES(null, @date, @staff_id, @patient_id, @service_id)", con))
                {
                    com.Parameters.AddWithValue("@date", dateTimePickerAppointment.Value.ToString("yyyy-MM-dd"));
                    com.Parameters.AddWithValue("@staff_id", id);
                    com.Parameters.AddWithValue("@patient_id", selectedUser);
                    com.Parameters.AddWithValue("@service_id", ((KeyValuePair<int, string>)comboBoxServices.SelectedItem).Key);

                    DialogResult r = MessageBox.Show("Appoint patient", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (r == DialogResult.OK)
                    {
                        com.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Cancelled");
                    }
                }
                con.Close();
            }
            refreshTables();
        }

        private void dataGridViewPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedUser = int.Parse(dataGridViewPatients.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
            MessageBox.Show("You have selected " + dataGridViewPatients.Rows[e.RowIndex].Cells[1].FormattedValue.ToString() + " for appointment");
        }
    }

}
