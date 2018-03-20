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
    public partial class Diagnosis2 : Form
    {
        public Diagnosis1 ref_To_Main { get; set; }
        public Diagnosis2()
        {
            InitializeComponent();
        }

        public Boolean validate()
        {
            if (txtCREA.Text == "")
            {
                MessageBox.Show("Invalid CREA");
                return false;
            }
            if (txtSGPT.Text == "")
            {
                MessageBox.Show("Invalid SGPT");
                return false;
            }
            if (txtPBS.Text == "")
            {
                MessageBox.Show("Invalid PBS");
                return false;
            }
            if (txtURIC.Text == "")
            {
                MessageBox.Show("Invalid URIC Acid");
                return false;
            }
            if (txtChest.Text == "")
            {
                MessageBox.Show("Invalid Chest Result");
                return false;
            }
            if (txtMonth.Text == "")
            {
                MessageBox.Show("Invalid Sputum Months");
                return false;
            }
            if (txtResult.Text == "")
            {
                MessageBox.Show("Invalid Sputum Result");
                return false;
            }
            if (txtAppearance.Text == "")
            {
                MessageBox.Show("Invalid Appearance");
                return false;
            }
            if (txtDoctor.Text == "")
            {
                MessageBox.Show("Invalid Doctor's order");
                return false;
            }
            if (txtVisual1.Text == "")
            {
                MessageBox.Show("Invalid Visual Appearance 1");
                return false;
            }
            if (txtVisual2.Text == "")
            {
                MessageBox.Show("Invalid Visual Appearance 2");
                return false;
            }
            if (txtVisualX.Text == "")
            {
                MessageBox.Show("Invalid Visual Xpert");
                return false;
            }
            if (txtreading1.Text == "")
            {
                MessageBox.Show("Invalid Reading 1");
                return false;
            }
            if (txtreading2.Text == "")
            {
                MessageBox.Show("Invalid Reading 2");
                return false;
            }
            if (txtReadingX.Text == "")
            {
                MessageBox.Show("Invalid Reading Xpert");
                return false;
            }
            if (txtLabDiag.Text == "")
            {
                MessageBox.Show("Invalid Laboratory Diagnosis");
                return false;
            }
            if (txtLabX.Text == "")
            {
                MessageBox.Show("Invalid Laboratory Xpert");
                return false;
            }
            if (radButtonAnti.Checked == false && radButtonNoAnti.Checked == false && radButonStop.Checked == false)
            {
                MessageBox.Show("Invalid TBDC Recommendations. Please Choose one");
                return false;
            }
            if (txtSug.Text == "")
            {
                MessageBox.Show("Invalid Suggestions. Please Choose one.");
                return false;
            }
            return true;
        }

        public Diagnosis2(int selectID, string firstname, string middlename, string lastname, string lab_crea,
            string lab_sgpt, string lab_FBS, string lab_acid, string chest_XrayResult, string sputum_month,
            string sputum_due, string sputum_examDate, string sputum_result, string sputum_appearance,
            string doctors_order, string exam_reason, string hist_treatment, string specimen_type, string specimen_date1,
            string speciman_date2, string test_request, string prepared_by, string staff_position, string visual_appearance1,
            string visual_appearance2, string visual_appearanceXpert, string reading1, string reading2,
            string readingX, string LabDiag, string LabX, string tbdc_rec, string suggestions)
        {
            InitializeComponent();
            lblID.Text = selectID.ToString();
            lblName.Text = lastname + ", " + firstname + " " + middlename;

            txtCREA.Text = lab_crea;
            txtSGPT.Text = lab_sgpt;
            txtPBS.Text = lab_FBS;
            txtURIC.Text = lab_acid;
            txtChest.Text = chest_XrayResult;
            txtMonth.Text = sputum_month;
            txtResult.Text = sputum_result;
            txtAppearance.Text = sputum_appearance;
            txtDoctor.Text = doctors_order;
            txtVisual1.Text = visual_appearance1;
            txtVisual2.Text = visual_appearance2;
            txtVisualX.Text = visual_appearanceXpert;
            txtreading1.Text = reading1;
            txtreading2.Text = reading2;
            txtReadingX.Text = readingX;
            txtLabDiag.Text = LabDiag;
            txtLabX.Text = LabX;
            txtSug.Text = suggestions;
            if (tbdc_rec == "Anti-TB Treatment")
            {
                radButtonAnti.Checked = true;
            }
            if (tbdc_rec == "No Anti-TB Treatment")
            {
                radButtonNoAnti.Checked = true;
            }
            if (tbdc_rec == "Stop Anti-TB Treatment")
            {
                radButonStop.Checked = true;
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("UPDATE registration SET lab_crea = @lab_crea, lab_sgpt = @lab_sgpt, lab_FBS = @lab_FBS, lab_acid = @lab_acid, chest_XrayResult = @chest_XrayResult, sputum_month = @sputum_month, sputum_due = @sputum_due, sputum_examDate = @sputum_examDate, sputum_result = @sputum_result, sputum_appearance = @sputum_appearance, doctors_order = @doctors_order, visual_appearance1 = @visual_appearance1, visual_appearance2 = @visual_appearance2, visual_appearanceXpert = @visual_appearanceXpert, reading1 = @reading1, reading2 = @reading2, readingX = @readingX, LabDiag = @LabDiag, LabX = @LabX, tbdc_rec = @tbdc_rec, suggestions = @suggestions WHERE registration_id = @registration_id", con))
                {
                    com.Parameters.AddWithValue("@registration_id", lblID.Text);
                    com.Parameters.AddWithValue("@lab_crea", txtCREA.Text);
                    com.Parameters.AddWithValue("@lab_sgpt", txtSGPT.Text);
                    com.Parameters.AddWithValue("@lab_FBS", txtPBS.Text);
                    com.Parameters.AddWithValue("@lab_acid", txtURIC.Text);
                    com.Parameters.AddWithValue("@chest_XrayResult", txtChest.Text);
                    com.Parameters.AddWithValue("@sputum_month", txtMonth.Text);
                    com.Parameters.AddWithValue("@sputum_due", dateTimeDue.Value.ToString("yyyy-MM-dd"));
                    com.Parameters.AddWithValue("@sputum_examDate", dateTimeExam.Value.ToString("yyyy-MM-dd"));
                    com.Parameters.AddWithValue("@sputum_result", txtResult.Text);
                    com.Parameters.AddWithValue("@sputum_appearance", txtAppearance.Text);
                    com.Parameters.AddWithValue("@doctors_order", txtDoctor.Text);
                    com.Parameters.AddWithValue("@visual_appearance1", txtVisual1.Text);
                    com.Parameters.AddWithValue("@visual_appearance2", txtVisual2.Text);
                    com.Parameters.AddWithValue("@visual_appearanceXpert", txtVisualX.Text);
                    com.Parameters.AddWithValue("@reading1", txtreading1.Text);
                    com.Parameters.AddWithValue("@reading2", txtreading2.Text);
                    com.Parameters.AddWithValue("@readingX", txtReadingX.Text);
                    com.Parameters.AddWithValue("@LabDiag", txtLabDiag.Text);
                    com.Parameters.AddWithValue("@LabX", txtLabX.Text);
                    com.Parameters.AddWithValue("@suggestions", txtSug.Text);

                    if (radButtonAnti.Checked)
                    {
                        com.Parameters.AddWithValue("@tbdc_rec", radButtonAnti.Text);
                    }

                    if (radButtonNoAnti.Checked)
                    {
                        com.Parameters.AddWithValue("@tbdc_rec", radButtonNoAnti.Text);
                    }

                    if (radButonStop.Checked)
                    {
                        com.Parameters.AddWithValue("@tbdc_rec", radButonStop.Text);
                    }


                    DialogResult r = MessageBox.Show("Apply Laboratory Results?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (r == DialogResult.OK && validate())
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
        }

        private void checkBoxStopSMK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStopSMK.Checked)
            {
                txtSug.AppendText(checkBoxStopSMK.Text + ", ");
            }
        }

        private void checkBoxBsugar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBsugar.Checked)
            {
                txtSug.AppendText(checkBoxBsugar.Text + ", ");
            }
        }

        private void checkBoxHousehold_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHousehold.Checked)
            {
                txtSug.AppendText(checkBoxHousehold.Text + ", ");
            }
        }

        private void checkBoxClearance_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxClearance.Checked)
            {
                txtSug.AppendText(checkBoxClearance.Text + ", ");
            }
        }

        private void checkBoxStable_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStable.Checked)
            {
                txtSug.AppendText(checkBoxStable.Text + ", ");
            }
        }

        private void checkBoxObserve_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxObserve.Checked)
            {
                txtSug.AppendText(checkBoxStable.Text + ", ");
            }
        }

        private void checkBoxSugSGPT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSugSGPT.Checked)
            {
                txtSug.AppendText(checkBoxSugSGPT.Text + ", ");
            }
        }

        private void checkBoxBiopsy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBiopsy.Checked)
            {
                txtSug.AppendText(checkBoxBiopsy.Text + ", ");
            }
        }

        private void checkBoxChestCT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChestCT.Checked)
            {
                txtSug.AppendText(checkBoxChestCT.Text + ", ");
            }
        }

        private void checkBoxSputum_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSputum.Checked)
            {
                txtSug.AppendText(checkBoxChestCT.Text + ", ");
            }
        }

        private void checkBoxGen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGen.Checked)
            {
                txtSug.AppendText(checkBoxGen.Text + ", ");
            }
        }

        private void checkBoxConsent_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxConsent.Checked)
            {
                txtSug.AppendText(checkBoxConsent.Text + ", ");
            }
        }

        private void checkBoxRx_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRx.Checked)
            {
                txtSug.AppendText(checkBoxRx.Text + ", ");
            }
        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                txtSug.AppendText(checkBoxFind.Text + ", ");
            }
        }

        private void checkBoxDSSM_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDSSM.Checked)
            {
                txtSug.AppendText(checkBoxDSSM.Text + ", ");
            }
        }

        private void checkBoxCXR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCXR.Checked)
            {
                txtSug.AppendText(checkBoxCXR.Text + ", ");
            }
        }

        private void checkBoxPMDT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPMDT.Checked)
            {
                txtSug.AppendText(checkBoxPMDT.Text + ", ");
            }
        }

        private void checkBoxPresent_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPresent.Checked)
            {
                txtSug.AppendText(checkBoxPresent.Text + ", ");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSug.Text = "";
            checkBoxStopSMK.Checked = false;
            checkBoxBsugar.Checked = false;
            checkBoxHousehold.Checked = false;
            checkBoxClearance.Checked = false;
            checkBoxStable.Checked = false;
            checkBoxObserve.Checked = false;
            checkBoxSugSGPT.Checked = false;
            checkBoxBiopsy.Checked = false;
            checkBoxChestCT.Checked = false;
            checkBoxSputum.Checked = false;
            checkBoxGen.Checked = false;
            checkBoxConsent.Checked = false;
            checkBoxRx.Checked = false;
            checkBoxFind.Checked = false;
            checkBoxDSSM.Checked = false;
            checkBoxCXR.Checked = false;
            checkBoxPMDT.Checked = false;
            checkBoxPresent.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCREA.Text = "55";
            txtSGPT.Text = "34";
            txtPBS.Text = "17";
            txtURIC.Text = "5";
            txtChest.Text = "Uhh";
            txtMonth.Text = "2";
            txtResult.Text = "wow";
            txtAppearance.Text = "Yellowish Slimey Color";
            txtDoctor.Text = "Go home and rest :)";
            txtVisual1.Text = "awfafa";
            txtVisual2.Text = "covfefe";
            txtVisualX.Text = "ho ho ho";
            txtreading1.Text = "iz good";
            txtreading2.Text = "iz well";
            txtReadingX.Text = "hmm?";
            txtLabDiag.Text = "ayy";
            txtLabX.Text = "noo";
            txtSug.Text = "Cough";
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();

                int selectedService = -1;

                using (var com = new MySqlCommand("SELECT services FROM registration WHERE registration_id = @registration_id", con))
                {
                    com.Parameters.AddWithValue("@registration_id", lblID.Text);

                    using (var rdr = com.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            selectedService = rdr.GetInt32(0);
                        }
                    }
                }

                Boolean main = true; Boolean other = true;

                string product_id = "-1", product_quantity = "-1";
                string[] other_products_id = { }, other_products_quantity = { };


                using (var com = new MySqlCommand("SELECT product_id, product_quantity, other_products_id, other_products_quantity FROM services WHERE service_id = @service_id", con))
                {
                    com.Parameters.AddWithValue("@service_id", selectedService);

                    using (var rdr = com.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            product_id = rdr.GetString(0);
                            product_quantity = rdr.GetString(1);

                            other_products_id = rdr.GetString(2).Split('/');
                            other_products_quantity = rdr.GetString(3).Split('/');
                        }
                    }
                }
                using (var com = new MySqlCommand("SELECT COUNT(status) count FROM inventory WHERE product_id = @product_id AND status = 'Normal'", con))
                {
                    com.Parameters.AddWithValue("@product_id", product_id);

                    using (var rdr = com.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            if (rdr.GetInt32(0) <= int.Parse(product_quantity))
                            {
                                main = false;
                                using (var con2 = new MySqlConnection(conClass.connectionString))
                                {
                                    con2.Open();
                                    using (var com2 = new MySqlCommand("SELECT name, dosage FROM products WHERE id = @id", con2))
                                    {
                                        com2.Parameters.AddWithValue("@id", product_id);
                                        using (var rdr2 = com2.ExecuteReader())
                                        {
                                            if (rdr2.Read())
                                            {
                                                if (rdr2.HasRows)
                                                {
                                                    MessageBox.Show(rdr2.GetString(0) + " " + rdr2.GetString(1) + " is out of stock");
                                                }
                                            }
                                        }
                                    }
                                    con2.Close();
                                }
                            }
                        }
                    }
                }

                int count = 0;

                if (other_products_id[0] != "")
                {
                    foreach (string x in other_products_id)
                    {
                        using (var com = new MySqlCommand("SELECT COUNT(status) count FROM inventory WHERE product_id = @product_id AND status = 'Normal'", con))
                        {
                            com.Parameters.AddWithValue("@product_id", x);

                            using (var rdr = com.ExecuteReader())
                            {
                                if (rdr.Read())
                                {
                                    if (rdr.GetInt32(0) <= int.Parse(other_products_quantity[count]))
                                    {
                                        other = false;
                                        using (var con2 = new MySqlConnection(conClass.connectionString))
                                        {
                                            con2.Open();
                                            using (var com2 = new MySqlCommand("SELECT name, dosage FROM products WHERE id = @id", con2))
                                            {
                                                com2.Parameters.AddWithValue("@id", x);
                                                using (var rdr2 = com2.ExecuteReader())
                                                {
                                                    if (rdr2.Read())
                                                    {
                                                        if (rdr2.HasRows)
                                                        {
                                                            MessageBox.Show(rdr2.GetString(0) + " " + rdr2.GetString(1) + " is out of stock");
                                                        }
                                                    }
                                                }
                                            }
                                            con2.Close();
                                        }
                                    }
                                }
                            }
                        }
                        count++;
                    }
                }

                count = 0;

                if (main && other)
                {
                    for (int i = 0; i < int.Parse(product_quantity); i++)
                    {
                        using (var com = new MySqlCommand("UPDATE inventory SET status = 'Expired' WHERE product_id = @product_id AND status = 'Normal' ORDER BY id, expiration_date ASC LIMIT 1", con))
                        {
                            com.Parameters.AddWithValue("@product_id", product_id);

                            com.ExecuteNonQuery();
                        }
                    }
                    if (other_products_id[0] != "")
                    {
                        foreach (string x in other_products_id)
                        {
                            for (int i = 0; i < int.Parse(other_products_quantity[count]); i++)
                            {
                                using (var com = new MySqlCommand("UPDATE inventory SET status = 'Expired' WHERE product_id = @product_id AND status = 'Normal' ORDER BY id, expiration_date ASC LIMIT 1", con))
                                {
                                    com.Parameters.AddWithValue("@product_id", x);

                                    com.ExecuteNonQuery();
                                }
                            }
                            count++;
                        }
                    }

                    using (var con2 = new MySqlConnection(conClass.connectionString))
                    {
                        con2.Open();
                        using (var com2 = new MySqlCommand("SELECT price FROM services WHERE service_id = @service_id", con2))
                        {
                            com2.Parameters.AddWithValue("@service_id", selectedService);
                            using (var rdr2 = com2.ExecuteReader())
                            {
                                if (rdr2.Read())
                                {
                                    if (rdr2.HasRows)
                                    {
                                        MessageBox.Show("Service successful\nTotal Bill is:\n PHP: " + rdr2.GetString(0));
                                    }
                                }
                            }
                        }
                        con2.Close();
                    }
                }
                else
                {
                    MessageBox.Show("More products required");
                }

                con.Close();
            }
        }
    }
}
