using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProject
{
    public partial class frmIPv4Validator : Form
    {
        public frmIPv4Validator()
        {
            InitializeComponent();
        }

        private void frmIPv4Validator_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            lblIPValDate.Text = currentDate.ToLongDateString();
        }

        private void lblIPValDate_Click(object sender, EventArgs e)
        {

        }
    }
}
