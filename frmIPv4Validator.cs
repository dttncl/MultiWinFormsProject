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

        private void btnIPVal_Click(object sender, EventArgs e)
        {
            string ipAddress = txtIPVal.Text.Trim();
            if (Regex.IsMatch(ipAddress, @"^(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}$"))
            {
                MessageBox.Show($"{ipAddress}\nThis IP is correct","Valid IP");
            }
            else
            {
                MessageBox.Show($"{ipAddress}\n" +
                    $"The IP must have 4 bytes\n" +
                    $"Integer number between 0 to 255\n" +
                    $"Separated by a dot (255.255.255.255)", "Error");
            }
        }
    }
}
