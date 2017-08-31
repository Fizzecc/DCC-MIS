using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DavaoChestCenter
{
    public partial class formModule1 : Form
    {
        int id = -1;
        string name = "";

        public formModule1()
        {
            InitializeComponent();
        }

        public formModule1(int x, string y)
        {
            InitializeComponent();

            id = x;
            name = y;
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            var profile = new formProfile(id, name);
            profile.ShowDialog();
        }

        private void buttonAppoinment_Click(object sender, EventArgs e)
        {
            var appointment = new formAppointment(id);
            appointment.ShowDialog();
        }

        private void buttonDiagnosis_Click(object sender, EventArgs e)
        {
            var labresult = new formLaboratory();
            labresult.ShowDialog();
        }
    }
}
