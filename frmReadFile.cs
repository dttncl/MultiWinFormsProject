﻿using System;
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
    public partial class frmReadFile : Form
    {
        public frmReadFile()
        {
            InitializeComponent();
        }

        public string strOutput { get; set; }

        private void rtfReadBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmReadFile_Load(object sender, EventArgs e)
        {
            rtfReadBox.Text = strOutput;
        }
    }
}
