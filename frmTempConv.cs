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
            decimal convTemp;

            try
            {
                // BASIC FUNCTION
                string inputTemp = txtTempFrom.Text.Trim();
                tempConvert.Temp = Convert.ToDecimal(inputTemp);

                char unitFrom, unitTo;
                if (optCtoF.Checked)
                {
                    // convert temp from C to F
                    convTemp = tempConvert.ConvertToFarenheit();
                    txtTempTo.Text = convTemp.ToString();
                    unitFrom = 'C';
                    unitTo = 'F';

                    // change text color
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
                    // convert temp from F to C
                    convTemp = tempConvert.ConvertToCelcius();
                    txtTempTo.Text = convTemp.ToString();
                    unitFrom = 'F';
                    unitTo = 'C';

                    // change text color
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

                // display temp description
                string tempDescription = tempConvert.DescribeTemperature(unitFrom);
                rtfTempDesc.Text = tempDescription;

                // WRITE TO TEXT FILE
                DataStream toWrite = new DataStream();

                toWrite.FileName = "TempConv";
                toWrite.MsgBoxTitle = "Temperature Conversion";
                toWrite.Output = $"{inputTemp} {unitFrom} = {convTemp} {unitTo}";

                // remove line break before saving to text file
                tempDescription = tempDescription.Replace("\n","").Replace("\r"," ");
                toWrite.Description = "  " + tempDescription;

                toWrite.WriteFile();

            }
            catch (Exception err)
            {
                MessageBox.Show($"Error! {err.Message}", "Exception Error");
                txtTempFrom.Text = "0";
                rtfTempDesc.Text = "";
                txtTempFrom.Focus();
            }
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

        private void frmTempConv_Load(object sender, EventArgs e)
        {
            optCtoF.Checked = true;
            optFtoC.Checked = false;
            txtTempFrom.Text = "0";
            txtTempTo.Text = "0";
            rtfTempDesc.Text = "";
        }

        private void btnTConvRead_Click(object sender, EventArgs e)
        {
            // READ TEXT FILE
            DataStream toRead = new DataStream();
            toRead.FileName = "TempConv";
            toRead.MsgBoxTitle = "Temperature Conversion";

            frmReadFile readDisplay = new frmReadFile();
            readDisplay.fileOutput = toRead.ReadFile();
            readDisplay.frmTitle = toRead.MsgBoxTitle;
            readDisplay.Show();
        }

        private void btnTConvExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close this window? ", "Close Temp Converter", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
