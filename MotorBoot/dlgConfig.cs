using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorBoot
{
    public partial class dlgConfig : Form
    {
        public string address;

        public dlgConfig()
        {
            InitializeComponent();            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            address = txtAddress.Text.Trim();
        }

        private void dlgConfig_Load(object sender, EventArgs e)
        {
            txtAddress.Text = address;
            txtAddress.Focus();
        }
    }
}
