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
            optCAD.Checked = true;
            optToCAD.Checked = true;
            txtConvFrom.Text = "0";
            txtConvTo.Text = "0";
        }

        string currencyFrom, currencyTo;

        private void btnMEx_Click(object sender, EventArgs e)
        {
            // BASIC FUNCTION
            CurrencyEx moneyConvert = new CurrencyEx();       

            // FROM Group
            if (optUSD.Checked)
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
            else if (optCAD.Checked)
            {
                currencyFrom = "CAD";
            }

            // TO Group
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
            else if (optToCAD.Checked)
            {
                currencyTo = "CAD";
            }

            try
            {
                moneyConvert.Amt = Convert.ToDecimal(txtConvFrom.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error! {err.Message}","Exception Error");
                txtConvFrom.Focus();
            }

            // convert amount to CAD
            decimal convCAD = moneyConvert.ConvertToCAD(currencyFrom);

            // convert CAD to any amount
            decimal convCurrency = moneyConvert.ConvertToCurrency(convCAD, currencyTo);
            txtConvTo.Text = convCurrency.ToString();

            // WRITE TO TEXT FILE
            DataStream toWrite = new DataStream();

            toWrite.FileName = "MoneyConv";
            toWrite.MsgBoxTitle = "Money Conversion";
            toWrite.Output = $"{moneyConvert.Amt} {currencyFrom} = {convCurrency} {currencyTo}";
            toWrite.Description = "";

            toWrite.WriteFile();

        }

        private void btnMExRead_Click(object sender, EventArgs e)
        {
            // READ TEXT FILE
            DataStream toRead = new DataStream();

            toRead.FileName = "MoneyConv";
            toRead.MsgBoxTitle = "Money Conversion";

            toRead.ReadFile();
        }

        private void btnMExExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close this window? ", "Close Money Exchange", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
