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
                using (var com = new MySqlCommand("SELECT * FROM appointments", con))
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
                            if (updateQuantity())
                            {
                                //.ExecuteNonQuery();
                            }
                            else
                            {
                                MessageBox.Show("Items are out of stock for this to continue");
                            }
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

        public Boolean updateQuantity()
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                int serviceid = -1;

                using (var com = new MySqlCommand("SELECT service_id FROM appointments WHERE id = @id", con))
                {
                    com.Parameters.AddWithValue("@id", selectedAppointment);

                    using (var rdr = com.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            rdr.Read();

                            serviceid = rdr.GetInt32(0);
                        }
                    }
                }

                int product_id = -1, product_quantity = -1;
                string other_products_id = "", other_products_quantity = "";

                using (var com = new MySqlCommand("SELECT product_id, product_quantity, other_products_id, other_products_quantity FROM services WHERE service_id = @id", con))
                {
                    com.Parameters.AddWithValue("@id", serviceid);

                    using (var rdr = com.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            rdr.Read();

                            product_id = rdr.GetInt32(0);
                            product_quantity = rdr.GetInt32(1);

                            other_products_id = rdr.GetString(2);
                            other_products_quantity = rdr.GetString(3);
                        }
                    }
                }
                Boolean mainChecker = true;

                int mainquantity = -1; int mainselectedproduct = -1; int finalquantity = -1; int selectedProduct = -1;

                using (var com = new MySqlCommand("SELECT id, product_id, quantity FROM transactions WHERE product_id = @id AND status = 'Normal' AND processed = 'Yes'", con))
                {
                    com.Parameters.AddWithValue("@id", product_id);

                    using (var rdr = com.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            rdr.Read();

                            mainselectedproduct = rdr.GetInt32(0);

                            mainquantity = rdr.GetInt32(2);

                            finalquantity = mainquantity - product_quantity;

                            rdr.Close();

                            if (finalquantity >= 0)
                            {

                            }
                            else
                            {
                                MessageBox.Show("Product ID: " + product_id + " is required to continue");
                                mainChecker = false;
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Product ID: " + product_id + " There is no stock");
                        }
                    }
                }

                if (mainChecker)
                {
                    string[] other_products = other_products_id.Split('/');
                    string[] products_quantity = other_products_quantity.Split('/');

                    int count = 0;

                    Boolean checker = true;

                    foreach (string x in other_products)
                    {
                        using (var com = new MySqlCommand("SELECT id, product_id, quantity FROM transactions WHERE product_id = @id AND status = 'Normal' AND processed = 'Yes'", con))
                        {
                            com.Parameters.AddWithValue("@id", x);

                            int selectedOtherProduct = -1;

                            using (var rdr = com.ExecuteReader())
                            {
                                if (rdr.HasRows)
                                {
                                    rdr.Read();

                                    selectedOtherProduct = rdr.GetInt32(0);

                                    int quantity = rdr.GetInt32(2);

                                    int final = quantity - int.Parse(products_quantity[count]);

                                    count++;

                                    rdr.Close();

                                    if (!(final >= 0))
                                    {
                                        MessageBox.Show("Product ID: " + x + " is required to continue");
                                        checker = false;
                                        return false;
                                    }
                                }
                                else
                                {
                                    checker = false;
                                    return false;
                                }
                            }
                        }
                    }

                    count = 0;
                    
                    if (checker)
                    {
                        using (var comfinal = new MySqlCommand("UPDATE transactions SET quantity = @quantity WHERE id = @id", con))
                        {
                            comfinal.Parameters.AddWithValue("@quantity", finalquantity);
                            comfinal.Parameters.AddWithValue("@id", mainselectedproduct);
                            comfinal.ExecuteNonQuery();
                        }

                        MessageBox.Show("Main Transaction ID: " + mainselectedproduct + " final quantity is " + finalquantity.ToString());

                        foreach (string x in other_products)
                        {
                            using (var com = new MySqlCommand("SELECT id, product_id, quantity FROM transactions WHERE product_id = @id AND status = 'Normal' AND processed = 'Yes'", con))
                            {
                                com.Parameters.AddWithValue("@id", x);

                                int selectedOtherProduct = -1;

                                using (var rdr = com.ExecuteReader())
                                {
                                    if (rdr.HasRows)
                                    {
                                        rdr.Read();

                                        selectedOtherProduct = rdr.GetInt32(0);

                                        int quantity = rdr.GetInt32(2);

                                        int final = quantity - int.Parse(products_quantity[count]);

                                        count++;

                                        rdr.Close();

                                        MessageBox.Show("Product ID: " + x + " Transaction ID: " + selectedOtherProduct + " final quantity is " + final.ToString());

                                        if (final >= 0)
                                        {
                                            using (var com2 = new MySqlCommand("UPDATE transactions SET quantity = @quantity WHERE id = @id", con))
                                            {
                                                com2.Parameters.AddWithValue("@quantity", final);
                                                com2.Parameters.AddWithValue("@id", selectedOtherProduct);
                                                com2.ExecuteNonQuery();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("no");
                                            checker = false;
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Fatal error");
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("More items are required to continue");
                        return false;
                    }
                }
                con.Close();
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formRegistration3 reg = new formRegistration3();
            reg.Show();
        }
    }

}
