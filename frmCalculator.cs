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
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();

        }

        // initiate the constructor
        Calculator calculate = new Calculator();
        private string numBuilder = "";

        private void btn1_Click(object sender, EventArgs e)
        {
            numBuilder += "1";
            txtCalc.Text = numBuilder;            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            numBuilder += "2";
            txtCalc.Text = numBuilder;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            numBuilder += "3";
            txtCalc.Text = numBuilder;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            numBuilder += "4";
            txtCalc.Text = numBuilder;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            numBuilder += "5";
            txtCalc.Text = numBuilder;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            numBuilder += "6";
            txtCalc.Text = numBuilder;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            numBuilder += "7";
            txtCalc.Text = numBuilder;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            numBuilder += "8";
            txtCalc.Text = numBuilder;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            numBuilder += "9";
            txtCalc.Text = numBuilder;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            numBuilder += "0";
            txtCalc.Text = numBuilder;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            numBuilder += ".";
            txtCalc.Text = numBuilder;
        }
        
        public List<double> listNumbers = new List<double>();
        private bool btnAddClicked = false;
        private bool btnSubClicked = false;
        private bool btnMulClicked = false;
        private bool btnDivClicked = false;

        private void btnAdd_Click(object sender, EventArgs e)
        {

            // when clicked, push the current numBuilder into the list (index 0)
            listNumbers.Add(Convert.ToDouble(numBuilder));

            // reset numBuilder to allow input of next number and clear the textbox
            numBuilder = "";
            txtCalc.Clear();

            // set to true
            btnAddClicked = true;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            // when clicked, push the current numBuilder into the list (index 0)
            listNumbers.Add(Convert.ToDouble(numBuilder));

            // reset numBuilder to allow input of next number and clear the textbox
            numBuilder = "";
            txtCalc.Clear();

            // set to true
            btnSubClicked = true;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            // when clicked, push the current numBuilder into the list (index 0)
            listNumbers.Add(Convert.ToDouble(numBuilder));

            // reset numBuilder to allow input of next number and clear the textbox
            numBuilder = "";
            txtCalc.Clear();

            // set to true
            btnMulClicked = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            // when clicked, push the current numBuilder into the list (index 0)
            listNumbers.Add(Convert.ToDouble(numBuilder));

            // reset numBuilder to allow input of next number and clear the textbox
            numBuilder = "";
            txtCalc.Clear();

            // set to true
            btnDivClicked = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            // when clicked, push the second numBuilder into the list (index 1)
            listNumbers.Add(Convert.ToDouble(numBuilder));

            // pass the first and second number in the list as Num1 and Num2
            calculate.Num1 = listNumbers[0];
            calculate.Num2 = listNumbers[1];

            numBuilder = "";
            double res = 0;

            // calculate depending on which operation was clicked
            if (btnAddClicked)
            {
                res = calculate.Add();
                btnAddClicked = false;

                // reset numBuilder to allow input of next number
                listNumbers.Clear();
            }
            else if (btnSubClicked)
            {
                res = calculate.Sub();
                btnSubClicked = false;
                listNumbers.Clear();
            }
            else if (btnMulClicked)
            {
                res = calculate.Mul();
                btnMulClicked = false;
                listNumbers.Clear();
            }
            else if (btnDivClicked)
            {
                res = calculate.Div();
                btnDivClicked = false;
                listNumbers.Clear();
            }

            txtCalc.Text = res.ToString();
            numBuilder = res.ToString();
        }

        private void btnCalcClear_Click(object sender, EventArgs e)
        {
            txtCalc.Clear();
            numBuilder = "";
           
        }

        private void btnCalcExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
