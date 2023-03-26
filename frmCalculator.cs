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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WinFormProject
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();

        }
        
        private void frmCalculator_Load(object sender, EventArgs e)
        {
           
        }

        // initiate the constructor
        Calculator calculate = new Calculator();
        private string numBuilder = "";

        public List<double> listNumbers = new List<double>();

        private bool btnAddClicked = false;
        private bool btnSubClicked = false;
        private bool btnMulClicked = false;
        private bool btnDivClicked = false;
        private bool btnEqualClicked = false;
        double res;

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(numBuilder);
            listNumbers.Add(num);
            numBuilder = "";

            if (!btnEqualClicked)
            {
                if (btnSubClicked)
                {
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];
                    res = calculate.Sub();
                    txtCalc.Text = res.ToString();

                    listNumbers.Clear();
                    listNumbers.Add(res);
                    btnSubClicked = false;

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

                }
            }
            else if (btnEqualClicked)
            {
                listNumbers.RemoveRange(1, 2);
                txtCalc.Text = res.ToString();
                btnEqualClicked = false;
                btnAddClicked = false;
                btnSubClicked = false;
                btnMulClicked = false;
                btnDivClicked = false;
            }


            btnAddClicked = true;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {


                double num = Convert.ToDouble(numBuilder);
                listNumbers.Add(num);
                numBuilder = "";

            if (!btnEqualClicked)
            {
                if (btnSubClicked)
                {
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];
                    res = calculate.Sub();
                    txtCalc.Text = res.ToString();

                    listNumbers.Clear();
                    listNumbers.Add(res);
                    btnSubClicked = false;

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

                }
            }
            else if (btnEqualClicked)
            {
                listNumbers.RemoveRange(1, 2);
                txtCalc.Text = res.ToString();
                btnEqualClicked = false;
                btnAddClicked = false;
                btnSubClicked = false;
                btnMulClicked = false;
                btnDivClicked = false;
            }


            btnSubClicked = true;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {

            double num = Convert.ToDouble(numBuilder);
            listNumbers.Add(num);
            numBuilder = "";

            if (!btnEqualClicked)
            {
                if (btnSubClicked)
                {
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];
                    res = calculate.Sub();
                    txtCalc.Text = res.ToString();

                    listNumbers.Clear();
                    listNumbers.Add(res);
                    btnSubClicked = false;

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

                }
            }
            else if (btnEqualClicked)
            {
                listNumbers.RemoveRange(1, 2);
                txtCalc.Text = res.ToString();
                btnEqualClicked = false;
                btnAddClicked = false;
                btnSubClicked = false;
                btnMulClicked = false;
                btnDivClicked = false;
            }

            btnMulClicked = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {

                double num = Convert.ToDouble(numBuilder);
                listNumbers.Add(num);
                numBuilder = "";

            if (!btnEqualClicked)
            {
                if (btnSubClicked)
                {
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];
                    res = calculate.Sub();
                    txtCalc.Text = res.ToString();

                    listNumbers.Clear();
                    listNumbers.Add(res);
                    btnSubClicked = false;

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

                }
            }
            else if (btnEqualClicked)
            {
                listNumbers.RemoveRange(1, 2);
                txtCalc.Text = res.ToString();
                btnEqualClicked = false;
                btnAddClicked = false;
                btnSubClicked = false;
                btnMulClicked = false;
                btnDivClicked = false;
            }


            btnDivClicked = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(numBuilder);
            listNumbers.Add(num);
            double temp = num;

            if (btnAddClicked)
            {
                calculate.Num1 = listNumbers[0];
                calculate.Num2 = listNumbers[1];
                res = calculate.Add();
                txtCalc.Text = res.ToString();

                listNumbers.Clear();
                listNumbers.Add(res);
                listNumbers.Add(temp);
            }
            else if (btnSubClicked)
            {
                calculate.Num1 = listNumbers[0];
                calculate.Num2 = listNumbers[1];
                res = calculate.Sub();
                txtCalc.Text = res.ToString();

                listNumbers.Clear();
                listNumbers.Add(res);
                listNumbers.Add(temp);
            }
            else if (btnMulClicked)
            {
                calculate.Num1 = listNumbers[0];
                calculate.Num2 = listNumbers[1];
                res = calculate.Mul();
                txtCalc.Text = res.ToString();

                listNumbers.Clear();
                listNumbers.Add(res);
                listNumbers.Add(temp);
            }
            else if (btnDivClicked)
            {
                calculate.Num1 = listNumbers[0];
                calculate.Num2 = listNumbers[1];
                res = calculate.Div();
                txtCalc.Text = res.ToString();

                listNumbers.Clear();
                listNumbers.Add(res);
                listNumbers.Add(temp);
            }

            btnEqualClicked = true;

        }

        private void frmCalculator_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.NumPad0)
            {
                btn0.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.NumPad1)
            {
                btn1.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.NumPad2)
            {
                btn2.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.NumPad3)
            {
                btn3.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.NumPad4)
            {
                btn4.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.NumPad5)
            {
                btn5.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.NumPad6)
            {
                btn6.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.NumPad7)
            {
                btn7.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.NumPad8)
            {
                btn8.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.NumPad9)
            {
                btn9.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Decimal)
            {
                btnDecimal.PerformClick();
                e.Handled = true;
            }
        }
    }
}
