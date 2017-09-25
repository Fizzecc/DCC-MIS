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
    public partial class formProductNew : Form
    {
        public formModule2 referenceToMain { get; set; }

        public formProductNew()
        {
            InitializeComponent();
        }

        private void buttonProductEncode_Click(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("INSERT INTO products VALUES(null, @name, @type, @dosage, @minimum_quantity)", con))
                {
                    try
                    {
                        com.Parameters.AddWithValue("@name", textBoxProductName.Text);
                        com.Parameters.AddWithValue("@minimum_quantity", int.Parse(textBoxProductMinimum.Text));
                        com.Parameters.AddWithValue("@dosage", int.Parse(textBoxDosage.Text) + "/" + comboBoxDoseType.Text);


                        if (checkBoxConsumable.Checked)
                        {
                            com.Parameters.AddWithValue("@type", "Consumable");
                        }

                        if (checkBoxConsumableNon.Checked)
                        {
                            com.Parameters.AddWithValue("@type", "Non-consumable");
                        }

                        DialogResult r = MessageBox.Show("Encode product", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                        if (r == DialogResult.OK)
                        {
                            com.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Cancelled");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalid quantity");
                    }
                }
                con.Close();
            }
            referenceToMain.renew();
        }

        private void checkBoxConsumable_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxConsumableNon.Checked = false;
        }

        private void checkBoxConsumableNon_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxConsumable.Checked = false;
        }
    }
}
