using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Bernadette Fernando
// April 18 2023
// This windows form will provide access to different forms that are able to do the following:
// Generate Numbers, Convert Currency, Calsulator, IPv4 Validator 

namespace WinFormProject
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void btnLottoMax_Click(object sender, EventArgs e)
        {
            frmMax app = new frmMax();
            app.Show();
        }

        private void btnMainExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application? ", "Exit ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void btnLotto649_Click(object sender, EventArgs e)
        {
            frm649 app = new frm649();
            app.Show();
        }

        private void btnMoneyEx_Click(object sender, EventArgs e)
        {
            frmMoneyEx app = new frmMoneyEx();
            app.Show();
        }

        private void btnTempConv_Click(object sender, EventArgs e)
        {
            frmTempConv app = new frmTempConv();
            app.Show();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            frmCalculator app = new frmCalculator();
            app.Show();
        }

        private void btnIPVal_Click(object sender, EventArgs e)
        {
            frmIPv4Validator app = new frmIPv4Validator();
            app.Show();
        }
    }

}