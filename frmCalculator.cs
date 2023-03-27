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
            toWrite.MsgBoxTitle = "Calculator";
        }

        // initiate constructors
        // Calculator - handle calculations
        Calculator calculate = new Calculator();
        // Datastream - handle read and write to text file
        DataStream toWrite = new DataStream();

        // variable to build the number
        private string numBuilder = "";

        // list that will hold the number inputs and results
        public List<double> listNumbers = new List<double>();

        // set the state of the buttons
        private bool btnAddClicked = false;
        private bool btnSubClicked = false;
        private bool btnMulClicked = false;
        private bool btnDivClicked = false;
        private bool btnEqualClicked = false;
        private bool btnDecClicked = false;
        double res;

        // number buttons
        private void btn1_Click(object sender, EventArgs e)
        {
            // if equal btn is already clicked, reset the string before input of new number 
            if (btnEqualClicked)
            {
                numBuilder = "";
                btnEqualClicked = false;
            }

            numBuilder += "1";
            txtCalc.Text = numBuilder;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btnEqualClicked)
            {
                numBuilder = "";
                btnEqualClicked = false;
            }
            numBuilder += "2";
            txtCalc.Text = numBuilder;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btnEqualClicked)
            {
                numBuilder = "";
                btnEqualClicked = false;
            }
            numBuilder += "3";
            txtCalc.Text = numBuilder;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btnEqualClicked)
            {
                numBuilder = "";
                btnEqualClicked = false;
            }
            numBuilder += "4";
            txtCalc.Text = numBuilder;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btnEqualClicked)
            {
                numBuilder = "";
                btnEqualClicked = false;
            }
            numBuilder += "5";
            txtCalc.Text = numBuilder;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btnEqualClicked)
            {
                numBuilder = "";
                btnEqualClicked = false;
            }
            numBuilder += "6";
            txtCalc.Text = numBuilder;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btnEqualClicked)
            {
                numBuilder = "";
                btnEqualClicked = false;
            }
            numBuilder += "7";
            txtCalc.Text = numBuilder;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btnEqualClicked)
            {
                numBuilder = "";
                btnEqualClicked = false;
            }
            numBuilder += "8";
            txtCalc.Text = numBuilder;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btnEqualClicked)
            {
                numBuilder = "";
                btnEqualClicked = false;
            }
            numBuilder += "9";
            txtCalc.Text = numBuilder;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (btnEqualClicked)
            {
                numBuilder = "";
                btnEqualClicked = false;
            }
            numBuilder += "0";
            txtCalc.Text = numBuilder;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            // make sure that decimal is not clicked more than once
            if (!btnDecClicked)
            {
                if (btnEqualClicked)
                {
                    numBuilder = "0";
                    btnEqualClicked = false;
                }
                numBuilder += ".";
                txtCalc.Text = numBuilder;
                btnDecClicked = true;
            }

        }


        // operation buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // store the value in the number builder
                double num = Convert.ToDouble(numBuilder);

                // add the number to list
                listNumbers.Add(num);

                // reset the number builder
                numBuilder = "";

                // if equal sign is not clicked, perform operation on first and second item in number list
                // then reset the state of operator buttons
                if (!btnEqualClicked)
                {
                    if (btnSubClicked)
                    {
                        calculate.Num1 = listNumbers[0];
                        calculate.Num2 = listNumbers[1];
                        res = calculate.Solve(listNumbers, "btnSubClicked");
                        txtCalc.Text = res.ToString();


                        toWrite.Output = $"{calculate.Num1} - {calculate.Num2} = {res}";
                        toWrite.WriteCalcFile();

                        btnSubClicked = false;
                    }
                    else if (btnMulClicked)
                    {
                        calculate.Num1 = listNumbers[0];
                        calculate.Num2 = listNumbers[1];
                        res = calculate.Solve(listNumbers, "btnMulClicked");
                        txtCalc.Text = res.ToString();


                        toWrite.Output = $"{calculate.Num1} * {calculate.Num2} = {res}";
                        toWrite.WriteCalcFile();

                        btnMulClicked = false;
                    }
                    else if (btnDivClicked)
                    {
                        calculate.Num1 = listNumbers[0];
                        calculate.Num2 = listNumbers[1];
                        res = calculate.Solve(listNumbers, "btnDivClicked");
                        txtCalc.Text = res.ToString();


                        toWrite.Output = $"{calculate.Num1} / {calculate.Num2} = {res}";
                        toWrite.WriteCalcFile();

                        btnDivClicked = false;
                    }
                    else if (btnAddClicked)
                    {
                        calculate.Num1 = listNumbers[0];
                        calculate.Num2 = listNumbers[1];
                        res = calculate.Solve(listNumbers, "btnAddClicked");
                        txtCalc.Text = res.ToString();


                        toWrite.Output = $"{calculate.Num1} + {calculate.Num2} = {res}";
                        toWrite.WriteCalcFile();

                        btnAddClicked = false;
                    }
                }

                // if equal sign is clicked
                // from index 1, remove 2 items (values added by equal btn event)
                // display the last value of result
                else if (btnEqualClicked)
                {
                    listNumbers.RemoveRange(1, 2);
                    txtCalc.Text = res.ToString();

                    // reset the state of all btns
                    btnEqualClicked = btnAddClicked = btnSubClicked = btnMulClicked = btnDivClicked = false;
                }

                // change state when btn is clicked
                btnAddClicked = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error! Please input a number.", "Invalid Input");
            }

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
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
                        res = calculate.Solve(listNumbers, "btnSubClicked");
                        txtCalc.Text = res.ToString();


                        toWrite.Output = $"{calculate.Num1} - {calculate.Num2} = {res}";
                        toWrite.WriteCalcFile();

                        btnSubClicked = false;
                    }
                    else if (btnMulClicked)
                    {
                        calculate.Num1 = listNumbers[0];
                        calculate.Num2 = listNumbers[1];
                        res = calculate.Solve(listNumbers, "btnMulClicked");
                        txtCalc.Text = res.ToString();


                        toWrite.Output = $"{calculate.Num1} * {calculate.Num2} = {res}";
                        toWrite.WriteCalcFile();

                        btnMulClicked = false;
                    }
                    else if (btnDivClicked)
                    {
                        calculate.Num1 = listNumbers[0];
                        calculate.Num2 = listNumbers[1];
                        res = calculate.Solve(listNumbers, "btnDivClicked");
                        txtCalc.Text = res.ToString();


                        toWrite.Output = $"{calculate.Num1} / {calculate.Num2} = {res}";
                        toWrite.WriteCalcFile();

                        btnDivClicked = false;
                    }
                    else if (btnAddClicked)
                    {
                        calculate.Num1 = listNumbers[0];
                        calculate.Num2 = listNumbers[1];
                        res = calculate.Solve(listNumbers, "btnAddClicked");
                        txtCalc.Text = res.ToString();


                        toWrite.Output = $"{calculate.Num1} + {calculate.Num2} = {res}";
                        toWrite.WriteCalcFile();

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
            catch (Exception)
            {
                MessageBox.Show("Error! Please input a number.", "Invalid Input");
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            try
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
                        res = calculate.Solve(listNumbers, "btnSubClicked");
                        txtCalc.Text = res.ToString();


                        toWrite.Output = $"{calculate.Num1} - {calculate.Num2} = {res}";
                        toWrite.WriteCalcFile();

                        btnSubClicked = false;
                    }
                    else if (btnMulClicked)
                    {
                        calculate.Num1 = listNumbers[0];
                        calculate.Num2 = listNumbers[1];
                        res = calculate.Solve(listNumbers, "btnMulClicked");
                        txtCalc.Text = res.ToString();


                        toWrite.Output = $"{calculate.Num1} * {calculate.Num2} = {res}";
                        toWrite.WriteCalcFile();

                        btnMulClicked = false;
                    }
                    else if (btnDivClicked)
                    {
                        calculate.Num1 = listNumbers[0];
                        calculate.Num2 = listNumbers[1];
                        res = calculate.Solve(listNumbers, "btnDivClicked");
                        txtCalc.Text = res.ToString();


                        toWrite.Output = $"{calculate.Num1} / {calculate.Num2} = {res}";
                        toWrite.WriteCalcFile();

                        btnDivClicked = false;
                    }
                    else if (btnAddClicked)
                    {
                        calculate.Num1 = listNumbers[0];
                        calculate.Num2 = listNumbers[1];
                        res = calculate.Solve(listNumbers, "btnAddClicked");
                        txtCalc.Text = res.ToString();


                        toWrite.Output = $"{calculate.Num1} + {calculate.Num2} = {res}";
                        toWrite.WriteCalcFile();

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
            catch (Exception)
            {
                MessageBox.Show("Error! Please input a number.", "Invalid Input");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
try
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
                        res = calculate.Solve(listNumbers, "btnSubClicked");
                        txtCalc.Text = res.ToString();


                        toWrite.Output = $"{calculate.Num1} - {calculate.Num2} = {res}";
                        toWrite.WriteCalcFile();

                        btnSubClicked = false;
                    }
                    else if (btnMulClicked)
                    {
                        calculate.Num1 = listNumbers[0];
                        calculate.Num2 = listNumbers[1];
                        res = calculate.Solve(listNumbers, "btnMulClicked");
                        txtCalc.Text = res.ToString();


                        toWrite.Output = $"{calculate.Num1} * {calculate.Num2} = {res}";
                        toWrite.WriteCalcFile();

                        btnMulClicked = false;
                    }
                    else if (btnDivClicked)
                    {
                        calculate.Num1 = listNumbers[0];
                        calculate.Num2 = listNumbers[1];
                        res = calculate.Solve(listNumbers, "btnDivClicked");
                        txtCalc.Text = res.ToString();


                        toWrite.Output = $"{calculate.Num1} / {calculate.Num2} = {res}";
                        toWrite.WriteCalcFile();

                        btnDivClicked = false;
                    }
                    else if (btnAddClicked)
                    {
                        calculate.Num1 = listNumbers[0];
                        calculate.Num2 = listNumbers[1];
                        res = calculate.Solve(listNumbers, "btnAddClicked");
                        txtCalc.Text = res.ToString();


                        toWrite.Output = $"{calculate.Num1} + {calculate.Num2} = {res}";
                        toWrite.WriteCalcFile();

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
            catch (Exception)
            {
                MessageBox.Show("Error! Please input a number.", "Invalid Input");
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                double num = Convert.ToDouble(numBuilder);
                listNumbers.Add(num);

                // store a copy of the number in a temp variable
                double temp = num;

                if (btnAddClicked)
                {
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];
                    res = calculate.Add();

                    txtCalc.Text = res.ToString();


                    toWrite.Output = $"{calculate.Num1} + {calculate.Num2} = {res}";
                    toWrite.WriteCalcFile();

                    // clear the list
                    // add the result and temp value into the list
                    // res: index 0, temp: index 1

                    listNumbers.Clear();
                    listNumbers.Add(res);
                    listNumbers.Add(temp);

                    // this will allow user to perform last operation
                    // using the last number every time equal btn is clicked
                }
                else if (btnSubClicked)
                {
                    calculate.Num1 = listNumbers[0];
                    calculate.Num2 = listNumbers[1];
                    res = calculate.Sub();

                    txtCalc.Text = res.ToString();


                    toWrite.Output = $"{calculate.Num1} - {calculate.Num2} = {res}";
                    toWrite.WriteCalcFile();

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


                    toWrite.Output = $"{calculate.Num1} * {calculate.Num2} = {res}";
                    toWrite.WriteCalcFile();

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


                    toWrite.Output = $"{calculate.Num1} / {calculate.Num2} = {res}";
                    toWrite.WriteCalcFile();

                    listNumbers.Clear();
                    listNumbers.Add(res);
                    listNumbers.Add(temp);
                }

                // change state of equal btn
                btnEqualClicked = true;
            } 
            catch (Exception)
            {
                MessageBox.Show("Error! Please input a number.","Invalid Input");
            }
            
        }

        private void btnCalcClear_Click(object sender, EventArgs e)
        {
            numBuilder = "";
            txtCalc.Text = "";
            listNumbers.Clear();
            btnEqualClicked = btnAddClicked = btnSubClicked = btnMulClicked = btnDivClicked = false;
        }

        private void btnCalcExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close this window? ", "Close Calculator", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}