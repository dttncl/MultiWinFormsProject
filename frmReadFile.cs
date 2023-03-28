using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProject
{
    public partial class frmReadFile : Form
    {
        public frmReadFile()
        {
            InitializeComponent();
        }

        public string fileOutput { get; set; }
        public string frmTitle { get; set; }

        private void frmReadFile_Load(object sender, EventArgs e)
        {
            rtfReadBox.Text = fileOutput;
            lblReadTitle.Text = frmTitle;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
