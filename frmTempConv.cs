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
    public partial class frmTempConv : Form
    {
        public frmTempConv()
        {
            InitializeComponent();
        }

        private void btnTConv_Click(object sender, EventArgs e)
        {
            ConvertTemp tempConvert = new ConvertTemp();
            tempConvert.Temp = Convert.ToDecimal(txtTempFrom.Text);

            char unitFrom = 'F';

            if (optCtoF.Checked)
            {
                txtTempTo.Text = tempConvert.ConvertToFarenheit().ToString();
                unitFrom = 'C';

                if (tempConvert.Temp >= 40)
                {
                    rtfTempDesc.ForeColor = Color.Red;
                }
                else if (tempConvert.Temp >= 21 && tempConvert.Temp < 40)
                {
                    rtfTempDesc.ForeColor = Color.Green;
                }
                else if (tempConvert.Temp < 21)
                {
                    rtfTempDesc.ForeColor = Color.Blue;
                }
            }
            else
            {
                txtTempTo.Text = tempConvert.ConvertToCelcius().ToString();

                if (tempConvert.Temp >= 104)
                {
                    rtfTempDesc.ForeColor = Color.Red;
                }
                else if (tempConvert.Temp >= 70 && tempConvert.Temp < 104)
                {
                    rtfTempDesc.ForeColor = Color.Green;
                }
                else if (tempConvert.Temp < 70)
                {
                    rtfTempDesc.ForeColor = Color.Blue;
                }
            }

            rtfTempDesc.Text = tempConvert.DescribeTemperature(unitFrom);

        }

        private void optFtoC_CheckedChanged(object sender, EventArgs e)
        {
            lblFrom.Text = "F";
            lblTo.Text = "C";
        }

        private void optCtoF_CheckedChanged(object sender, EventArgs e)
        {
            lblFrom.Text = "C";
            lblTo.Text = "F";
        }
    }
}
