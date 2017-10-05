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
        Dictionary<int, string> staff = new Dictionary<int, string>();

        int selectedStaff = -1;
        int selectedSchedule = -1;

        public formModule3()
        {
            InitializeComponent();

            refreshTable();

            gatherPeople();
        }

        public void refreshTable()
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT id, firstname, middlename, lastname, schedule_days, working_time_start, working_time_end FROM staff RIGHT JOIN schedules ON staff.id = schedules.staff_id", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewSchedule.DataSource = dt;

                    dataGridViewSchedule.Columns["id"].Visible = false;

                    dataGridViewSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewSchedule.AutoResizeColumns();

                    dataGridViewSchedule.BorderStyle = BorderStyle.None;
                    dataGridViewSchedule.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                    dataGridViewSchedule.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dataGridViewSchedule.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
                    dataGridViewSchedule.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                    dataGridViewSchedule.BackgroundColor = Color.White;

                    dataGridViewSchedule.EnableHeadersVisualStyles = false;
                    dataGridViewSchedule.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                    dataGridViewSchedule.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
                    dataGridViewSchedule.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                    dataGridViewSchedule.Columns["firstname"].HeaderText = "First Name";
                    dataGridViewSchedule.Columns["middlename"].HeaderText = "Middle Name";
                    dataGridViewSchedule.Columns["lastname"].HeaderText = "Last Name";
                    dataGridViewSchedule.Columns["schedule_days"].HeaderText = "Working Days";
                    dataGridViewSchedule.Columns["working_time_start"].HeaderText = "Working Time Start";
                    dataGridViewSchedule.Columns["working_time_end"].HeaderText = "Working Time End";
                }

                using (var com = new MySqlCommand("SELECT attendance.id, firstname, lastname, time_start, time_end FROM attendance LEFT JOIN staff ON attendance.person = staff.id WHERE date > DATE_SUB(NOW(), INTERVAL 1 DAY)", con))
                {
                    var adp = new MySqlDataAdapter(com);
                    var dt = new DataTable();
                    adp.Fill(dt);
                    dataGridViewToday.DataSource = dt;

                    dataGridViewToday.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewToday.AutoResizeColumns();

                    dataGridViewToday.BorderStyle = BorderStyle.None;
                    dataGridViewToday.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                    dataGridViewToday.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dataGridViewToday.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
                    dataGridViewToday.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                    dataGridViewToday.BackgroundColor = Color.White;

                    dataGridViewToday.EnableHeadersVisualStyles = false;
                    dataGridViewToday.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                    dataGridViewToday.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
                    dataGridViewToday.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                    dataGridViewToday.Columns["firstname"].HeaderText = "First Name";
                    dataGridViewToday.Columns["lastname"].HeaderText = "Last Name";
                    dataGridViewToday.Columns["time_start"].HeaderText = "Time Start";
                    dataGridViewToday.Columns["time_end"].HeaderText = "Time End";

                    dataGridViewToday.Columns["id"].Visible = false;
                }
                con.Close();
            }
        }

        private void timerCurrent_Tick(object sender, EventArgs e)
        {
            label1.Text = System.DateTime.Now.ToString("dddd, MMMM/dd/yyyy HH:mm:ss");
        }

        private void dataGridViewSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedStaff = int.Parse(dataGridViewSchedule.Rows[e.RowIndex].Cells["id"].Value.ToString());
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            if (selectedStaff != -1)
            {
                using (var con = new MySqlConnection(conClass.connectionString))
                {
                    con.Open();
                    using (var com = new MySqlCommand("INSERT INTO attendance VALUES(null, @person, @date, @time_start, '')", con))
                    {
                        com.Parameters.AddWithValue("@person", selectedStaff);
                        com.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                        com.Parameters.AddWithValue("@time_start", DateTime.Now.ToString("HH:mm:ss"));

                        com.ExecuteNonQuery();

                        refreshTable();
                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("select user first");
            }
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            if (selectedSchedule != -1)
            {
                using (var con = new MySqlConnection(conClass.connectionString))
                {
                    con.Open();
                    using (var com = new MySqlCommand("UPDATE attendance SET time_end = @time_end WHERE id = @id", con))
                    {
                        com.Parameters.AddWithValue("@time_end", DateTime.Now.ToString("HH:mm:ss"));
                        com.Parameters.AddWithValue("@id", selectedSchedule);

                        com.ExecuteNonQuery();

                        refreshTable();

                        sort();
                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("select schedule first");
            }
        }

        private void gatherPeople()
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                using (var com = new MySqlCommand("SELECT * FROM staff", con))
                {
                    using (var rdr = com.ExecuteReader())
                    {
                        while (rdr.HasRows)
                        {
                            if (rdr.Read())
                            {
                                staff.Add(rdr.GetInt32(0), rdr.GetString(1) + " " + rdr.GetString(3));

                                comboBox1.DataSource = new BindingSource(staff, null);
                                comboBox1.DisplayMember = "Value";
                                comboBox1.ValueMember = "Key";
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

        private void dataGridViewToday_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedSchedule = int.Parse(dataGridViewToday.Rows[e.RowIndex].Cells["id"].Value.ToString());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            sort();
        }

        public void sort()
        {
            using (var con = new MySqlConnection(conClass.connectionString))
            {
                con.Open();
                if (checkBox1.Checked == false)
                {
                    using (var com = new MySqlCommand("SELECT attendance.id, date, firstname, lastname, time_start, time_end FROM attendance LEFT JOIN staff ON attendance.person = staff.id WHERE (date BETWEEN @dateTimePicker1 AND @dateTimePicker2) AND staff.id = @staff_id", con))
                    {
                        com.Parameters.AddWithValue("@dateTimePicker1", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                        com.Parameters.AddWithValue("@dateTimePicker2", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                        com.Parameters.AddWithValue("@staff_id", ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key);

                        var adp = new MySqlDataAdapter(com);
                        var dt = new DataTable();
                        adp.Fill(dt);

                        dataGridViewAttendance.DataSource = dt;
                        dataGridViewAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridViewAttendance.AutoResizeColumns();
                        
                        dataGridViewAttendance.BorderStyle = BorderStyle.None;
                        dataGridViewAttendance.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                        dataGridViewAttendance.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                        dataGridViewAttendance.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
                        dataGridViewAttendance.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                        dataGridViewAttendance.BackgroundColor = Color.White;

                        dataGridViewAttendance.EnableHeadersVisualStyles = false;
                        dataGridViewAttendance.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                        dataGridViewAttendance.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
                        dataGridViewAttendance.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        
                        dataGridViewAttendance.Columns["id"].Visible = false;

                        dataGridViewAttendance.Columns["date"].HeaderText = "Date";
                        dataGridViewAttendance.Columns["firstname"].HeaderText = "First Name";
                        dataGridViewAttendance.Columns["lastname"].HeaderText = "Last Name";
                        dataGridViewAttendance.Columns["time_start"].HeaderText = "Time Start";
                        dataGridViewAttendance.Columns["time_end"].HeaderText = "Time End";
                    }
                }
                else
                {
                    using (var com = new MySqlCommand("SELECT attendance.id, date, firstname, lastname, time_start, time_end FROM attendance LEFT JOIN staff ON attendance.person = staff.id WHERE (date BETWEEN @dateTimePicker1 AND @dateTimePicker2)", con))
                    {
                        com.Parameters.AddWithValue("@dateTimePicker1", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                        com.Parameters.AddWithValue("@dateTimePicker2", dateTimePicker2.Value.ToString("yyyy-MM-dd"));

                        var adp = new MySqlDataAdapter(com);
                        var dt = new DataTable();
                        adp.Fill(dt);
                        dataGridViewAttendance.DataSource = dt;

                        dataGridViewAttendance.Columns["id"].Visible = false;
                    }
                }
                con.Close();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            sort();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            sort();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sort();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            sort();
        }
    }
}
