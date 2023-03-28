using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;


namespace WinFormProject
{
    public partial class frmIPv4Validator : Form
    {
        public frmIPv4Validator()
        {
            InitializeComponent();
        }

        DateTime openFormTime, closeFormTime;

        private void frmIPv4Validator_Load(object sender, EventArgs e)
        {
            openFormTime = DateTime.Now;
            lblIPValDate.Text = openFormTime.ToLongDateString();

        }

        private void btnIPVal_Click(object sender, EventArgs e)
        {
            // examples: 192.168.0.10 / 192.186.000
            string ipAddress = txtIPVal.Text.Trim();
            if (Regex.IsMatch(ipAddress, @"^(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}$"))
            {
                MessageBox.Show($"{ipAddress}\nThis IP is correct","Valid IP");

                DataStream toWrite = new DataStream();
                toWrite.FileName = "BinaryIpv4";
                toWrite.MsgBoxTitle = "IPv4 Validator";
                toWrite.Output = ipAddress;

                toWrite.WriteBinFile();
            }
            else if (ipAddress.Length == 0)
            {
                MessageBox.Show("Error! Please input an IPv4 address.", "Invalid IP");
            }
            else
            {
                MessageBox.Show($"{ipAddress}\n" +
                    $"The IP must have 4 bytes\n" +
                    $"Integer number between 0 to 255\n" +
                    $"Separated by a dot (255.255.255.255)", "Invalid IP");
            }
        }

        private void btnIPValReset_Click(object sender, EventArgs e)
        {
            txtIPVal.Text = "";
        }

        private void btnIPValExit_Click(object sender, EventArgs e)
        {
            closeFormTime = DateTime.Now;
            TimeSpan totRunTime = closeFormTime.Subtract(openFormTime);

            if (MessageBox.Show("Do you want to close this window?\n" +
                $"Total runtime: {totRunTime.Minutes} mins and {totRunTime.Seconds} seconds", "Close IPv4 Validator", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
