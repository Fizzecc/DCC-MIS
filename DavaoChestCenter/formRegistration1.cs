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
    public partial class formRegistration1 : Form
    {
        public formRegistration1()
        {
            InitializeComponent();
        }
        
        private void label11_Click(object sender, EventArgs e)
        {

        } 
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            formLaboratory two = new formLaboratory();
            two.ShowDialog();
        }
    }
}
