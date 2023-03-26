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
        char op;

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
                    op = '-';
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];

                    txtCalc.Text = calculate.Solve(listNumbers, "btnSubClicked").ToString();

                    // WRITE TO TEXT FILE
                    DataStream toWrite = new DataStream();
                    toWrite.FileName = "Calculator";
                    toWrite.MsgBoxTitle = "Calculator";
                    toWrite.Output = $"{calculate.Num1} {op} {calculate.Num2} = {res}";
                    toWrite.Description = "";
                    toWrite.WriteFile();

                    btnSubClicked = false;
                }
                else if (btnMulClicked)
                {
                    op = '*';
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];

                    txtCalc.Text = calculate.Solve(listNumbers, "btnMulClicked").ToString();

                    // WRITE TO TEXT FILE
                    DataStream toWrite = new DataStream();
                    toWrite.FileName = "Calculator";
                    toWrite.MsgBoxTitle = "Calculator";
                    toWrite.Output = $"{calculate.Num1} {op} {calculate.Num2} = {res}";
                    toWrite.Description = "";
                    toWrite.WriteFile();

                    btnMulClicked = false;
                }
                else if (btnDivClicked)
                {
                    op = '/';
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];

                    txtCalc.Text = calculate.Solve(listNumbers, "btnDivClicked").ToString();

                    // WRITE TO TEXT FILE
                    DataStream toWrite = new DataStream();
                    toWrite.FileName = "Calculator";
                    toWrite.MsgBoxTitle = "Calculator";
                    toWrite.Output = $"{calculate.Num1} {op} {calculate.Num2} = {res}";
                    toWrite.Description = "";
                    toWrite.WriteFile();

                    btnDivClicked = false;
                }
                else if (btnAddClicked)
                {
                    op = '+';
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];

                    txtCalc.Text = calculate.Solve(listNumbers, "btnAddClicked").ToString();

                    // WRITE TO TEXT FILE
                    DataStream toWrite = new DataStream();
                    toWrite.FileName = "Calculator";
                    toWrite.MsgBoxTitle = "Calculator";
                    toWrite.Output = $"{calculate.Num1} {op} {calculate.Num2} = {res}";
                    toWrite.Description = "";
                    toWrite.WriteFile();

                    btnAddClicked = false;
                }
            }
            else if (btnEqualClicked)
            {
                listNumbers.RemoveRange(1, 2);
                txtCalc.Text = res.ToString();
                btnEqualClicked = btnAddClicked = btnSubClicked = btnMulClicked = btnDivClicked =  false;
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
                    op = '-';
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];

                    txtCalc.Text = calculate.Solve(listNumbers, "btnSubClicked").ToString();

                    // WRITE TO TEXT FILE
                    DataStream toWrite = new DataStream();
                    toWrite.FileName = "Calculator";
                    toWrite.MsgBoxTitle = "Calculator";
                    toWrite.Output = $"{calculate.Num1} {op} {calculate.Num2} = {res}";
                    toWrite.Description = "";
                    toWrite.WriteFile();

                    btnSubClicked = false;
                }
                else if (btnMulClicked)
                {
                    op = '*';
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];

                    txtCalc.Text = calculate.Solve(listNumbers, "btnMulClicked").ToString();

                    // WRITE TO TEXT FILE
                    DataStream toWrite = new DataStream();
                    toWrite.FileName = "Calculator";
                    toWrite.MsgBoxTitle = "Calculator";
                    toWrite.Output = $"{calculate.Num1} {op} {calculate.Num2} = {res}";
                    toWrite.Description = "";
                    toWrite.WriteFile();

                    btnMulClicked = false;
                }
                else if (btnDivClicked)
                {
                    op = '/';
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];

                    txtCalc.Text = calculate.Solve(listNumbers, "btnDivClicked").ToString();

                    // WRITE TO TEXT FILE
                    DataStream toWrite = new DataStream();
                    toWrite.FileName = "Calculator";
                    toWrite.MsgBoxTitle = "Calculator";
                    toWrite.Output = $"{calculate.Num1} {op} {calculate.Num2} = {res}";
                    toWrite.Description = "";
                    toWrite.WriteFile();

                    btnDivClicked = false;
                }
                else if (btnAddClicked)
                {
                    op = '+';
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];

                    txtCalc.Text = calculate.Solve(listNumbers, "btnAddClicked").ToString();

                    // WRITE TO TEXT FILE
                    DataStream toWrite = new DataStream();
                    toWrite.FileName = "Calculator";
                    toWrite.MsgBoxTitle = "Calculator";
                    toWrite.Output = $"{calculate.Num1} {op} {calculate.Num2} = {res}";
                    toWrite.Description = "";
                    toWrite.WriteFile();

                    btnAddClicked = false;
                }
            }
            else if (btnEqualClicked)
            {
                listNumbers.RemoveRange(1, 2);
                txtCalc.Text = res.ToString();
                btnEqualClicked = btnAddClicked = btnSubClicked = btnMulClicked = btnDivClicked = false;
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
                    op = '-';
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];

                    txtCalc.Text = calculate.Solve(listNumbers, "btnSubClicked").ToString();

                    // WRITE TO TEXT FILE
                    DataStream toWrite = new DataStream();
                    toWrite.FileName = "Calculator";
                    toWrite.MsgBoxTitle = "Calculator";
                    toWrite.Output = $"{calculate.Num1} {op} {calculate.Num2} = {res}";
                    toWrite.Description = "";
                    toWrite.WriteFile();

                    btnSubClicked = false;
                }
                else if (btnMulClicked)
                {
                    op = '*';
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];

                    txtCalc.Text = calculate.Solve(listNumbers, "btnMulClicked").ToString();

                    // WRITE TO TEXT FILE
                    DataStream toWrite = new DataStream();
                    toWrite.FileName = "Calculator";
                    toWrite.MsgBoxTitle = "Calculator";
                    toWrite.Output = $"{calculate.Num1} {op} {calculate.Num2} = {res}";
                    toWrite.Description = "";
                    toWrite.WriteFile();

                    btnMulClicked = false;
                }
                else if (btnDivClicked)
                {
                    op = '/';
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];

                    txtCalc.Text = calculate.Solve(listNumbers, "btnDivClicked").ToString();

                    // WRITE TO TEXT FILE
                    DataStream toWrite = new DataStream();
                    toWrite.FileName = "Calculator";
                    toWrite.MsgBoxTitle = "Calculator";
                    toWrite.Output = $"{calculate.Num1} {op} {calculate.Num2} = {res}";
                    toWrite.Description = "";
                    toWrite.WriteFile();

                    btnDivClicked = false;
                }
                else if (btnAddClicked)
                {
                    op = '+';
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];

                    txtCalc.Text = calculate.Solve(listNumbers, "btnAddClicked").ToString();

                    // WRITE TO TEXT FILE
                    DataStream toWrite = new DataStream();
                    toWrite.FileName = "Calculator";
                    toWrite.MsgBoxTitle = "Calculator";
                    toWrite.Output = $"{calculate.Num1} {op} {calculate.Num2} = {res}";
                    toWrite.Description = "";
                    toWrite.WriteFile();

                    btnAddClicked = false;
                }
            }
            else if (btnEqualClicked)
            {
                listNumbers.RemoveRange(1, 2);
                txtCalc.Text = res.ToString();
                btnEqualClicked = btnAddClicked = btnSubClicked = btnMulClicked = btnDivClicked = false;
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
                    op = '-';
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];

                    txtCalc.Text = calculate.Solve(listNumbers, "btnSubClicked").ToString();

                    // WRITE TO TEXT FILE
                    DataStream toWrite = new DataStream();
                    toWrite.FileName = "Calculator";
                    toWrite.MsgBoxTitle = "Calculator";
                    toWrite.Output = $"{calculate.Num1} {op} {calculate.Num2} = {res}";
                    toWrite.Description = "";
                    toWrite.WriteFile();

                    btnSubClicked = false;
                }
                else if (btnMulClicked)
                {
                    op = '*';
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];

                    txtCalc.Text = calculate.Solve(listNumbers, "btnMulClicked").ToString();

                    // WRITE TO TEXT FILE
                    DataStream toWrite = new DataStream();
                    toWrite.FileName = "Calculator";
                    toWrite.MsgBoxTitle = "Calculator";
                    toWrite.Output = $"{calculate.Num1} {op} {calculate.Num2} = {res}";
                    toWrite.Description = "";
                    toWrite.WriteFile();

                    btnMulClicked = false;
                }
                else if (btnDivClicked)
                {
                    op = '/';
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];

                    txtCalc.Text = calculate.Solve(listNumbers, "btnDivClicked").ToString();

                    // WRITE TO TEXT FILE
                    DataStream toWrite = new DataStream();
                    toWrite.FileName = "Calculator";
                    toWrite.MsgBoxTitle = "Calculator";
                    toWrite.Output = $"{calculate.Num1} {op} {calculate.Num2} = {res}";
                    toWrite.Description = "";
                    toWrite.WriteFile();

                    btnDivClicked = false;
                }
                else if (btnAddClicked)
                {
                    op = '+';
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];

                    txtCalc.Text = calculate.Solve(listNumbers, "btnAddClicked").ToString();

                    // WRITE TO TEXT FILE
                    DataStream toWrite = new DataStream();
                    toWrite.FileName = "Calculator";
                    toWrite.MsgBoxTitle = "Calculator";
                    toWrite.Output = $"{calculate.Num1} {op} {calculate.Num2} = {res}";
                    toWrite.Description = "";
                    toWrite.WriteFile();

                    btnAddClicked = false;
                }
            }
            else if (btnEqualClicked)
            {
                listNumbers.RemoveRange(1, 2);
                txtCalc.Text = res.ToString();
                btnEqualClicked = btnAddClicked = btnSubClicked = btnMulClicked = btnDivClicked = false;
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
                op = '+';
                calculate.Num1 = listNumbers[0];
                calculate.Num2 = listNumbers[1];
                res = calculate.Add();

                // WRITE TO TEXT FILE
                DataStream toWrite = new DataStream();
                toWrite.FileName = "Calculator";
                toWrite.MsgBoxTitle = "Calculator";
                toWrite.Output = $"{calculate.Num1} {op} {calculate.Num2} = {res}";
                toWrite.Description = "";
                toWrite.WriteFile();

                txtCalc.Text = res.ToString();

                listNumbers.Clear();
                listNumbers.Add(res);
                listNumbers.Add(temp);
            }
            else if (btnSubClicked)
            {
                op = '-';
                calculate.Num1 = listNumbers[0];
                calculate.Num2 = listNumbers[1];
                res = calculate.Sub();

                // WRITE TO TEXT FILE
                DataStream toWrite = new DataStream();
                toWrite.FileName = "Calculator";
                toWrite.MsgBoxTitle = "Calculator";
                toWrite.Output = $"{calculate.Num1} {op} {calculate.Num2} = {res}";
                toWrite.Description = "";
                toWrite.WriteFile();

                txtCalc.Text = res.ToString();

                listNumbers.Clear();
                listNumbers.Add(res);
                listNumbers.Add(temp);
            }
            else if (btnMulClicked)
            {
                op = '*';
                calculate.Num1 = listNumbers[0];
                calculate.Num2 = listNumbers[1];
                res = calculate.Mul();

                // WRITE TO TEXT FILE
                DataStream toWrite = new DataStream();
                toWrite.FileName = "Calculator";
                toWrite.MsgBoxTitle = "Calculator";
                toWrite.Output = $"{calculate.Num1} {op} {calculate.Num2} = {res}";
                toWrite.Description = "";
                toWrite.WriteFile();

                txtCalc.Text = res.ToString();

                listNumbers.Clear();
                listNumbers.Add(res);
                listNumbers.Add(temp);
            }
            else if (btnDivClicked)
            {
                op = '/';
                calculate.Num1 = listNumbers[0];
                calculate.Num2 = listNumbers[1];
                res = calculate.Div();

                // WRITE TO TEXT FILE
                DataStream toWrite = new DataStream();
                toWrite.FileName = "Calculator";
                toWrite.MsgBoxTitle = "Calculator";
                toWrite.Output = $"{calculate.Num1} {op} {calculate.Num2} = {res}";
                toWrite.Description = "";
                toWrite.WriteFile();

                txtCalc.Text = res.ToString();

                listNumbers.Clear();
                listNumbers.Add(res);
                listNumbers.Add(temp);
            }

            btnEqualClicked = true;
        }
    }
}