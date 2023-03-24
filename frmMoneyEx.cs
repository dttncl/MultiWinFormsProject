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
    public partial class frmMoneyEx : Form
    {
        public frmMoneyEx()
        {
            InitializeComponent();
        }

        private void btnMEx_Click(object sender, EventArgs e)
        {
            CurrencyEx moneyConvert = new CurrencyEx();

            // FROM Group
            string currencyFrom = "CAD";

            if(optUSD.Checked)
            {
                currencyFrom = "USD";
            }
            else if (optEUR.Checked)
            {
                currencyFrom = "EUR";
            }
            else if (optGBP.Checked)
            {
                currencyFrom = "GBP";
            }
            else if (optPHP.Checked)
            {
                currencyFrom = "PHP";
            }

            // TO Group
            string currencyTo = "CAD";

            if (optToUSD.Checked)
            {
                currencyTo = "USD";
            }
            else if (optToEUR.Checked)
            {
                currencyTo = "EUR";
            }
            else if (optToGBP.Checked)
            {
                currencyTo = "GBP";
            }
            else if (optToPHP.Checked)
            {
                currencyTo = "PHP";
            }

            moneyConvert.Amt = Convert.ToDecimal(txtConvFrom.Text);

            // convert amount to CAD
            decimal convCAD = moneyConvert.ConvertToCAD(currencyFrom);

            // convert CAD to any amount
            txtConvTo.Text = moneyConvert.ConvertToCurrency(convCAD,currencyTo).ToString();
        }

        private void btnMExExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want\nto quit the application\nMoney Exchange? ", "Exit ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmMoneyEx_Load(object sender, EventArgs e)
        {

        }

        private void grpConvFrom_Enter(object sender, EventArgs e)
        {

        }
    }
}
