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

        int id = -1;

        public formAppointment(int x)
        {
            InitializeComponent();

            id = x;

            refreshTables();

            //gatherServices();
        }
        
        public void refreshTables()
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT registration_id, appointmentDate, patient_Fname, patient_Mname, patient_Lname, patient_status, patient_gender, services, age, address, contact_num1, ref_Phys, occupation, CPLname, CPFname, CPMname, CPrelation, CPcontact, CPaddress, weight FROM registration WHERE appointmentDate >= DATE_SUB(NOW(), INTERVAL 7 DAY)", con))
                {
                    using (var adp = new MySqlDataAdapter(com))
                    {
                        var dt = new DataTable();
                        adp.Fill(dt);
                        dataGridViewAppointments.DataSource = dt;
                        dt.Dispose();

                        dataGridViewAppointments.Columns["registration_id"].Visible = false;
                        dataGridViewAppointments.Columns["appointmentDate"].HeaderText = "Appointment Date";
                        dataGridViewAppointments.Columns["patient_Fname"].HeaderText = "First Name";
                        dataGridViewAppointments.Columns["patient_Mname"].HeaderText = "Middle Name";
                        dataGridViewAppointments.Columns["patient_Lname"].HeaderText = "Last Name";
                        dataGridViewAppointments.Columns["patient_status"].HeaderText = "Civil Status";
                        dataGridViewAppointments.Columns["patient_gender"].HeaderText = "Gender";
                        dataGridViewAppointments.Columns["services"].HeaderText = "Services";
                        dataGridViewAppointments.Columns["appointmentDate"].HeaderText = "Appointment Date";
                        dataGridViewAppointments.Columns["age"].HeaderText = "Age";
                        dataGridViewAppointments.Columns["address"].HeaderText = "Address";
                        dataGridViewAppointments.Columns["contact_num1"].HeaderText = "Contact Number";
                        dataGridViewAppointments.Columns["ref_Phys"].HeaderText = "Referral Physician";
                        dataGridViewAppointments.Columns["occupation"].HeaderText = "Occupation";
                        dataGridViewAppointments.Columns["CPLname"].HeaderText = "Contact Person's Last Name";
                        dataGridViewAppointments.Columns["CPFname"].HeaderText = "Contact Person's Full Name";
                        dataGridViewAppointments.Columns["CPMname"].HeaderText = "Contact Person's Middle Name";
                        dataGridViewAppointments.Columns["CPrelation"].HeaderText = "Contact Person's relation";
                        dataGridViewAppointments.Columns["CPaddress"].HeaderText = "Contact Person's address";
                        dataGridViewAppointments.Columns["weight"].HeaderText = "Weight";
                    }
                }
                con.Close();
            }

            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT * FROM registration", con))
                {
                    using (var adp = new MySqlDataAdapter(com))
                    {
                        var dt = new DataTable();
                        adp.Fill(dt);
                        dataGridViewPatients.DataSource = dt;
                        dt.Dispose();

                        dataGridViewPatients.Columns["registration_id"].Visible = false;

                        dataGridViewPatients.Columns["appointmentDate"].HeaderText = "Appointment Date";
                        dataGridViewPatients.Columns["patient_Fname"].HeaderText = "First Name";
                        dataGridViewPatients.Columns["patient_Mname"].HeaderText = "Middle Name";
                        dataGridViewPatients.Columns["patient_Lname"].HeaderText = "Last Name";
                        dataGridViewPatients.Columns["patient_status"].HeaderText = "Status";
                        dataGridViewPatients.Columns["patient_gender"].HeaderText = "Gender";
                        dataGridViewPatients.Columns["services"].HeaderText = "Services";
                        dataGridViewPatients.Columns["age"].HeaderText = "Age";
                        dataGridViewPatients.Columns["address"].HeaderText = "Address";
                        dataGridViewPatients.Columns["contact_num1"].HeaderText = "Contact Number";
                        dataGridViewPatients.Columns["ref_Phys"].HeaderText = "Referring Physician";
                        dataGridViewPatients.Columns["occupation"].HeaderText = "Occupation";
                        dataGridViewPatients.Columns["CPLname"].HeaderText = "Contact Person Last Name";
                        dataGridViewPatients.Columns["CPFname"].HeaderText = "Contact Person First Name";
                        dataGridViewPatients.Columns["CPMname"].HeaderText = "Contact Person Middle Name";
                        dataGridViewPatients.Columns["CPrelation"].HeaderText = "Contact Person Relation";
                        dataGridViewPatients.Columns["CPcontact"].HeaderText = "Contact Person's Number";
                        dataGridViewPatients.Columns["CPaddress"].HeaderText = "Contact Person's Address";
                        dataGridViewPatients.Columns["weight"].HeaderText = "Weight";
                        dataGridViewPatients.Columns["treatment_partner"].HeaderText = "Treatment Partner";
                        dataGridViewPatients.Columns["pulmonaries"].HeaderText = "Pulmonaries";
                        dataGridViewPatients.Columns["extra_pulmonaries"].HeaderText = "Extra_Pulmonaries";
                        dataGridViewPatients.Columns["diabetic"].HeaderText = "Diabetic";
                        dataGridViewPatients.Columns["hypertensive"].HeaderText = "Hypertensive";
                        dataGridViewPatients.Columns["smoke"].HeaderText = "smoke";
                        dataGridViewPatients.Columns["smoke_day"].HeaderText = "Times Smoking per day";
                        dataGridViewPatients.Columns["start_smoking"].HeaderText = "Started Smoking";
                        dataGridViewPatients.Columns["stop_smoking"].HeaderText = "Stopped Smoking";
                        dataGridViewPatients.Columns["prev_tb"].HeaderText = "Previous TB";
                        dataGridViewPatients.Columns["tb_months"].HeaderText = "Number of Months";
                        dataGridViewPatients.Columns["medicines"].HeaderText = "Medicines";
                        dataGridViewPatients.Columns["medicine_under"].HeaderText = "Medicines Taking";
                        dataGridViewPatients.Columns["alcoholic"].HeaderText = "Alcoholic";
                        dataGridViewPatients.Columns["alcohol_start"].HeaderText = "Started Drinking";
                        dataGridViewPatients.Columns["alcohol_stop"].HeaderText = "Stopped Drinking";
                        dataGridViewPatients.Columns["lab_crea"].HeaderText = "CREA";
                        dataGridViewPatients.Columns["lab_sgpt"].HeaderText = "SGPT";
                        dataGridViewPatients.Columns["lab_acid"].HeaderText = "ACID";
                        dataGridViewPatients.Columns["chest_XrayResult"].HeaderText = "X-Ray Result";
                        dataGridViewPatients.Columns["sputum_month"].HeaderText = "Sputum Month";
                        dataGridViewPatients.Columns["sputum_due"].HeaderText = "Sputum Due";
                        dataGridViewPatients.Columns["sputum_examDate"].HeaderText = "Sputum Exam Date";
                        dataGridViewPatients.Columns["sputum_result"].HeaderText = "Sputum Result";
                        dataGridViewPatients.Columns["sputum_appearance"].HeaderText = "Sputum Appearance";
                        dataGridViewPatients.Columns["doctors_order"].HeaderText = "Doctor's Order";
                        dataGridViewPatients.Columns["exam_reason"].HeaderText = "Reason for Examination";
                        dataGridViewPatients.Columns["hist_treatment"].HeaderText = "History Treatment";
                        dataGridViewPatients.Columns["specimen_type"].HeaderText = "Specimen Type";
                        dataGridViewPatients.Columns["specimen_date1"].HeaderText = "Specimen Date 1";
                        dataGridViewPatients.Columns["speciman_date2"].HeaderText = "Specimen Date 2";
                        dataGridViewPatients.Columns["test_request"].HeaderText = "Test Request";
                        dataGridViewPatients.Columns["prepared_by"].HeaderText = "Prepared By";
                        dataGridViewPatients.Columns["staff_position"].HeaderText = "Staff Position";
                        dataGridViewPatients.Columns["visual_appearance1"].HeaderText = "Visual Appearance 1";
                        dataGridViewPatients.Columns["visual_appearance2"].HeaderText = "Visual Appearance 2";
                        dataGridViewPatients.Columns["visual_appearanceXpert"].HeaderText = "Visual Appearance Xpert";
                        dataGridViewPatients.Columns["reading1"].HeaderText = "Reading 1";
                        dataGridViewPatients.Columns["reading2"].HeaderText = "Reading 2";
                        dataGridViewPatients.Columns["readingX"].HeaderText = "Reading Xpert";
                        dataGridViewPatients.Columns["LabDiag"].HeaderText = "Laboratory Diagnosis";
                        dataGridViewPatients.Columns["LabX"].HeaderText = "Laboratory Xpert";
                        dataGridViewPatients.Columns["tbdc_rec"].HeaderText = "TBDC Recording";
                        dataGridViewPatients.Columns["suggestions"].HeaderText = "Suggestions";
                    }
                }
                con.Close();
            }
        }
        /*
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
        */
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formRegistration reg = new formRegistration();
            reg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formRegistration reg = new formRegistration();
            reg.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT * FROM registration", con))
                {
                    using (var adp = new MySqlDataAdapter(com))
                    {
                        var dt = new DataTable();
                        adp.Fill(dt);
                        dataGridViewAppointments.DataSource = dt;
                        dt.Dispose();

                        dataGridViewAppointments.Columns["registration_id"].Visible = false;
                    }
                }
                con.Close();
            }
        }

        private void dataGridViewPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectIDpatients = int.Parse(dataGridViewPatients.Rows[e.RowIndex].Cells["registration_id"].Value.ToString());
            string firstname = dataGridViewPatients.Rows[e.RowIndex].Cells["patient_Fname"].Value.ToString();
            string middlename = dataGridViewPatients.Rows[e.RowIndex].Cells["patient_Mname"].Value.ToString();
            string lastname = dataGridViewPatients.Rows[e.RowIndex].Cells["patient_Lname"].Value.ToString();

            string pulmonaries = dataGridViewPatients.Rows[e.RowIndex].Cells["pulmonaries"].Value.ToString();
            string extra_pulmonaries = dataGridViewPatients.Rows[e.RowIndex].Cells["extra_pulmonaries"].Value.ToString();
            string diabetic = dataGridViewPatients.Rows[e.RowIndex].Cells["diabetic"].Value.ToString();
            string hypertensive = dataGridViewPatients.Rows[e.RowIndex].Cells["hypertensive"].Value.ToString();
            string smoke = dataGridViewPatients.Rows[e.RowIndex].Cells["smoke"].Value.ToString();
            string smoke_day = dataGridViewPatients.Rows[e.RowIndex].Cells["smoke_day"].Value.ToString();
            string start_smoking = dataGridViewPatients.Rows[e.RowIndex].Cells["start_smoking"].Value.ToString();
            string stop_smoking = dataGridViewPatients.Rows[e.RowIndex].Cells["stop_smoking"].Value.ToString();
            string prev_tb = dataGridViewPatients.Rows[e.RowIndex].Cells["prev_tb"].Value.ToString();
            string tb_months = dataGridViewPatients.Rows[e.RowIndex].Cells["tb_months"].Value.ToString();
            string tb_date = dataGridViewPatients.Rows[e.RowIndex].Cells["tb_date"].Value.ToString();
            string medicines = dataGridViewPatients.Rows[e.RowIndex].Cells["medicines"].Value.ToString();
            string medicine_under = dataGridViewPatients.Rows[e.RowIndex].Cells["medicine_under"].Value.ToString();
            string alcoholic = dataGridViewPatients.Rows[e.RowIndex].Cells["alcoholic"].Value.ToString();
            string alcohol_start = dataGridViewPatients.Rows[e.RowIndex].Cells["alcohol_start"].Value.ToString();
            string alcohol_stop = dataGridViewPatients.Rows[e.RowIndex].Cells["alcohol_stop"].Value.ToString();
            string exam_reason = dataGridViewPatients.Rows[e.RowIndex].Cells["exam_reason"].Value.ToString();
            string hist_treatment = dataGridViewPatients.Rows[e.RowIndex].Cells["hist_treatment"].Value.ToString();
            string specimen_type = dataGridViewPatients.Rows[e.RowIndex].Cells["specimen_type"].Value.ToString();
            string specimen_date1 = dataGridViewPatients.Rows[e.RowIndex].Cells["specimen_date1"].Value.ToString();
            string speciman_date2 = dataGridViewPatients.Rows[e.RowIndex].Cells["speciman_date2"].Value.ToString();
            string test_request = dataGridViewPatients.Rows[e.RowIndex].Cells["test_request"].Value.ToString();
            string prepared_by = dataGridViewPatients.Rows[e.RowIndex].Cells["prepared_by"].Value.ToString();
            string staff_position = dataGridViewPatients.Rows[e.RowIndex].Cells["staff_position"].Value.ToString();
            string treatment_partner = dataGridViewPatients.Rows[e.RowIndex].Cells["treatment_partner"].Value.ToString();


            var records = new formMedRecords(selectIDpatients, firstname, middlename, lastname, pulmonaries, extra_pulmonaries,
                diabetic, hypertensive, smoke, smoke_day, start_smoking, stop_smoking, prev_tb, tb_months, tb_date,
                medicines, medicine_under, alcoholic, alcohol_start, alcohol_stop, exam_reason, hist_treatment,
                specimen_type, specimen_date1, speciman_date2, test_request, prepared_by, staff_position, treatment_partner);
            records.ref_To_Main = this;
            records.ShowDialog();
        }

        private void formAppointment_Load(object sender, EventArgs e)
        {
            dataGridViewAppointments.BorderStyle = BorderStyle.None;
            dataGridViewAppointments.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewAppointments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewAppointments.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridViewAppointments.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewAppointments.BackgroundColor = Color.White;

            dataGridViewAppointments.EnableHeadersVisualStyles = false;
            dataGridViewAppointments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewAppointments.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewAppointments.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridViewPatients.BorderStyle = BorderStyle.None;
            dataGridViewPatients.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewPatients.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewPatients.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridViewPatients.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewPatients.BackgroundColor = Color.White;

            dataGridViewPatients.EnableHeadersVisualStyles = false;
            dataGridViewPatients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewPatients.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewPatients.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void dataGridViewAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectIDappointment = int.Parse(dataGridViewAppointments.Rows[e.RowIndex].Cells["registration_id"].Value.ToString());
            string firstname = dataGridViewAppointments.Rows[e.RowIndex].Cells["patient_Fname"].Value.ToString();
            string middlename = dataGridViewAppointments.Rows[e.RowIndex].Cells["patient_Mname"].Value.ToString();
            string lastname = dataGridViewAppointments.Rows[e.RowIndex].Cells["patient_Lname"].Value.ToString();
            string patient_status = dataGridViewAppointments.Rows[e.RowIndex].Cells["patient_status"].Value.ToString();
            string patient_gender = dataGridViewAppointments.Rows[e.RowIndex].Cells["patient_gender"].Value.ToString();
            string services = dataGridViewAppointments.Rows[e.RowIndex].Cells["services"].Value.ToString();
            //string  = dataGridViewPatients.Rows[e.RowIndex].Cells["appointmentDate"].Value.ToString();
            string age = dataGridViewAppointments.Rows[e.RowIndex].Cells["age"].Value.ToString();
            string address = dataGridViewAppointments.Rows[e.RowIndex].Cells["address"].Value.ToString();
            string contact_num1 = dataGridViewAppointments.Rows[e.RowIndex].Cells["contact_num1"].Value.ToString();
            string ref_Phys = dataGridViewAppointments.Rows[e.RowIndex].Cells["ref_Phys"].Value.ToString();
            string occupation = dataGridViewAppointments.Rows[e.RowIndex].Cells["occupation"].Value.ToString();
            string CPLname = dataGridViewAppointments.Rows[e.RowIndex].Cells["CPLname"].Value.ToString();
            string CPFname = dataGridViewAppointments.Rows[e.RowIndex].Cells["CPFname"].Value.ToString();
            string CPMname = dataGridViewAppointments.Rows[e.RowIndex].Cells["CPMname"].Value.ToString();
            string CPaddress = dataGridViewAppointments.Rows[e.RowIndex].Cells["CPaddress"].Value.ToString();
            string CPrelation = dataGridViewAppointments.Rows[e.RowIndex].Cells["CPrelation"].Value.ToString();
            string CPcontact = dataGridViewAppointments.Rows[e.RowIndex].Cells["CPcontact"].Value.ToString();
            string weight = dataGridViewAppointments.Rows[e.RowIndex].Cells["weight"].Value.ToString();

            var reg = new formRegistration(selectIDappointment, firstname, middlename, lastname, patient_status,
                patient_gender, services, age, address, contact_num1, ref_Phys, occupation, CPLname, CPFname,
                CPMname, CPaddress, CPrelation, CPcontact, weight);
            reg.ref_To_Main = this;
            reg.ShowDialog();
        }
    }

}
