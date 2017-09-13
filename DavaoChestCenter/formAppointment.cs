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
    public partial class formAppointment : Form
    {
        public Form form;
        Dictionary<int, string> services = new Dictionary<int, string>();

        int id = -1; int selectedUser = -1; int selectedAppointment = -1;

        public formAppointment(int x)
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

                        dataGridViewAppointments.Columns["id"].Visible = false;
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
                                services.Add(rdr.GetInt32(0), rdr.GetString(3));

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
            if (selectedUser != -1)
            {
                using (var con = new MySqlConnection(conClass.connectionString))
                {
                    con.Open();
                    using (var com = new MySqlCommand("INSERT INTO appointments VALUES(null, @date, @staff_id, @patient_id, @service_id, @done)", con))
                    {
                        com.Parameters.AddWithValue("@date", dateTimePickerAppointment.Value.ToString("yyyy-MM-dd"));
                        com.Parameters.AddWithValue("@staff_id", id);
                        com.Parameters.AddWithValue("@patient_id", selectedUser);
                        com.Parameters.AddWithValue("@service_id", ((KeyValuePair<int, string>)comboBoxServices.SelectedItem).Key);
                        com.Parameters.AddWithValue("@done", "False");

                        DialogResult r = MessageBox.Show("Appoint patient", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                        if (r == DialogResult.OK)
                        {
                            com.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Cancelled");
                        }

                        selectedUser = -1;
                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("You have not selected any user yet!");
            }
            refreshTables();
        }

        private void dataGridViewPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedUser = int.Parse(dataGridViewPatients.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
            MessageBox.Show("You have selected " + dataGridViewPatients.Rows[e.RowIndex].Cells[1].FormattedValue.ToString() + " for appointment");
        }

        private void dataGridViewAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedAppointment = int.Parse(dataGridViewAppointments.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
            MessageBox.Show("You have selected the appointment of " + dataGridViewAppointments.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (selectedAppointment != -1)
            {
                using (var con = new MySqlConnection(conClass.connectionString))
                {
                    con.Open();
                    using (var com = new MySqlCommand("UPDATE appointments SET done = 'True' WHERE id = @id", con))
                    {
                        com.Parameters.AddWithValue("@id", selectedAppointment);

                        DialogResult r = MessageBox.Show("Mark appointment as done?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                        if (r == DialogResult.OK)
                        {
                            com.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Cancelled");
                        }

                        selectedAppointment = -1;
                    }
                    con.Close();

                }
            }
            else
            {
                MessageBox.Show("You have not selected any appointment yet!");
            }
            refreshTables();
        }

        /*public void showForm(Form x)
        {
            if (form != null)
            {
                form.Dispose();

                form = x;
                form.TopLevel = false;
                panelForm.Controls.Add(form);
                form.Show();
            }
            else
            {
                form = x;
                form.TopLevel = false;
                panelForm.Controls.Add(form);
                form.Show();
            }
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            formRegistration3 reg = new formRegistration3();
            reg.Show();

            /*var appointment = new formAppointment(id);
            showForm(appointment);*/
        }

        private void dataGridViewAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form test = new formRegistration();
            test.Show();
        }
    }

}
