using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        public List<double> listNumbers = new List<double>();
        
        private void frmCalculator_Load(object sender, EventArgs e)
        {
           
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

        private bool btnAddClicked = false;
        private bool btnSubClicked = false;
        private bool btnMulClicked = false;
        private bool btnDivClicked = false;
        private bool btnEqualClicked = false;
        double res;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!btnEqualClicked)
            {
                double num = Convert.ToDouble(numBuilder);
                listNumbers.Add(num);
                numBuilder = "";

                if (btnSubClicked)
                {
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];
                    res = calculate.Sub();
                    txtCalc.Text = res.ToString();

                    listNumbers.Clear();
                    listNumbers.Add(res);
                    btnSubClicked = false;
                    btnEqualClicked = false;
                }
                else if (btnMulClicked)
                {
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];
                    res = calculate.Mul();
                    txtCalc.Text = res.ToString();

                    listNumbers.Clear();
                    listNumbers.Add(res);
                    btnMulClicked = false;
                    btnEqualClicked = false;
                }
                else if (btnDivClicked)
                {
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];
                    res = calculate.Div();
                    txtCalc.Text = res.ToString();

                    listNumbers.Clear();
                    listNumbers.Add(res);
                    btnDivClicked = false;
                    btnEqualClicked = false;
                }
                else if (btnAddClicked)
                {
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];
                    res = calculate.Add();
                    txtCalc.Text = res.ToString();

                    listNumbers.Clear();
                    listNumbers.Add(res);
                    btnAddClicked = false;
                    btnEqualClicked = false;
                }
            }

            btnAddClicked = true;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {

            if (!btnEqualClicked)
            {
                double num = Convert.ToDouble(numBuilder);
                listNumbers.Add(num);
                numBuilder = "";

                if (btnSubClicked)
                {
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];
                    res = calculate.Sub();
                    txtCalc.Text = res.ToString();

                    listNumbers.Clear();
                    listNumbers.Add(res);
                    btnSubClicked = false;
                    btnEqualClicked = false;
                }
                else if (btnMulClicked)
                {
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];
                    res = calculate.Mul();
                    txtCalc.Text = res.ToString();

                    listNumbers.Clear();
                    listNumbers.Add(res);
                    btnMulClicked = false;
                    btnEqualClicked = false;
                }
                else if (btnDivClicked)
                {
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];
                    res = calculate.Div();
                    txtCalc.Text = res.ToString();

                    listNumbers.Clear();
                    listNumbers.Add(res);
                    btnDivClicked = false;
                    btnEqualClicked = false;
                }
                else if (btnAddClicked)
                {
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];
                    res = calculate.Add();
                    txtCalc.Text = res.ToString();

                    listNumbers.Clear();
                    listNumbers.Add(res);
                    btnAddClicked = false;
                    btnEqualClicked = false;
                }
            }
            
            btnSubClicked = true;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (!btnEqualClicked)
            {

                double num = Convert.ToDouble(numBuilder);
                listNumbers.Add(num);
                numBuilder = "";

                if (btnSubClicked)
                {
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];
                    res = calculate.Sub();
                    txtCalc.Text = res.ToString();

                    listNumbers.Clear();
                    listNumbers.Add(res);
                    btnSubClicked = false;
                    btnEqualClicked = false;
                }
                else if (btnMulClicked)
                {
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];
                    res = calculate.Mul();
                    txtCalc.Text = res.ToString();

                    listNumbers.Clear();
                    listNumbers.Add(res);
                    btnMulClicked = false;
                    btnEqualClicked = false;
                }
                else if (btnDivClicked)
                {
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];
                    res = calculate.Div();
                    txtCalc.Text = res.ToString();

                    listNumbers.Clear();
                    listNumbers.Add(res);
                    btnDivClicked = false;
                    btnEqualClicked = false;
                }
                else if (btnAddClicked)
                {
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];
                    res = calculate.Add();
                    txtCalc.Text = res.ToString();

                    listNumbers.Clear();
                    listNumbers.Add(res);
                    btnAddClicked = false;
                    btnEqualClicked = false;
                }
            }

            btnMulClicked = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!btnEqualClicked) 
            {
                double num = Convert.ToDouble(numBuilder);
                listNumbers.Add(num);
                numBuilder = "";

                if (btnSubClicked)
                {
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];
                    res = calculate.Sub();
                    txtCalc.Text = res.ToString();

                    listNumbers.Clear();
                    listNumbers.Add(res);
                    btnSubClicked = false;
                    btnEqualClicked = false;
                }
                else if (btnMulClicked)
                {
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];
                    res = calculate.Mul();
                    txtCalc.Text = res.ToString();

                    listNumbers.Clear();
                    listNumbers.Add(res);
                    btnMulClicked = false;
                    btnEqualClicked = false;
                }
                else if (btnDivClicked)
                {
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];
                    res = calculate.Div();
                    txtCalc.Text = res.ToString();

                    listNumbers.Clear();
                    listNumbers.Add(res);
                    btnDivClicked = false;
                    btnEqualClicked = false;
                }
                else if (btnAddClicked)
                {
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];
                    res = calculate.Add();
                    txtCalc.Text = res.ToString();

                    listNumbers.Clear();
                    listNumbers.Add(res);
                    btnAddClicked = false;
                    btnEqualClicked = false;
                }
            }
           
            btnDivClicked = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(numBuilder);
            listNumbers.Add(num);
            numBuilder = "";

            if (btnSubClicked)
            {
                calculate.Num1 = listNumbers[0];
                calculate.Num2 = listNumbers[1];
                res = calculate.Sub();
                txtCalc.Text = res.ToString();

                listNumbers.Clear();
                listNumbers.Add(res);
                btnSubClicked = false;
                btnEqualClicked = false;
            }
            else if (btnMulClicked)
            {
                calculate.Num1 = listNumbers[0];
                calculate.Num2 = listNumbers[1];
                res = calculate.Mul();
                txtCalc.Text = res.ToString();

                listNumbers.Clear();
                listNumbers.Add(res);
                btnMulClicked = false;
                btnEqualClicked = false;
            }
            else if (btnDivClicked)
            {
                calculate.Num1 = listNumbers[0];
                calculate.Num2 = listNumbers[1];
                res = calculate.Div();
                txtCalc.Text = res.ToString();

                listNumbers.Clear();
                listNumbers.Add(res);
                btnDivClicked = false;
                btnEqualClicked = false;
            }
            else if (btnAddClicked)
            {
                calculate.Num1 = listNumbers[0];
                calculate.Num2 = listNumbers[1];
                res = calculate.Add();
                txtCalc.Text = res.ToString();

                listNumbers.Clear();
                listNumbers.Add(res);
                btnAddClicked = false;
                btnEqualClicked = false;
            }

            btnEqualClicked = true;
        }
    }
}
