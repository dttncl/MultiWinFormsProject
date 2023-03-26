using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormProject
{
    internal class Calculator
    {
        // fields
        private double num1;
        private double num2;
        // constructor
        public Calculator()
        {

        }
        
        public Calculator(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
        }
        // properties
        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        // methods
        public double Add()
        {
            return Num1 + Num2;
        }

        public double Sub()
        {
            return Num1 - Num2;
        }

        public double Mul()
        {
            return Num1 * Num2;
        }

        public double Div()
        {
            return Num1 / Num2;
        }

        public double Solve (List<double> listNumbers,string btn)
        {
            double res = 0;

            if (btn == "btnSubClicked")
            {
                res = Sub();
                listNumbers.Clear();
                listNumbers.Add(res);
            }
            else if (btn == "btnAddClicked")
            {
                res = Add();
                listNumbers.Clear();
                listNumbers.Add(res);
            }
            else if (btn == "btnMulClicked")
            {
                res = Mul();
                listNumbers.Clear();
                listNumbers.Add(res);
            }
            else if (btn == "btnDivClicked")
            {
                res = Div();
                listNumbers.Clear();
                listNumbers.Add(res);
            }

            return res;
        }


        //public double Equal(List<double> listNumbers, string btn, double temp)
        //{
        //    double res = 0;

        //    if (btn == "btnSubClicked")
        //    {
        //        res = Sub();
        //        listNumbers.Clear();
        //        listNumbers.Add(res);
        //        listNumbers.Add(temp);
        //    }
        //    else if (btn == "btnAddClicked")
        //    {
        //        res = Add();
        //        listNumbers.Clear();
        //        listNumbers.Add(res);
        //        listNumbers.Add(temp);
        //    }
        //    else if (btn == "btnMulClicked")
        //    {
        //        res = Mul();
        //        listNumbers.Clear();
        //        listNumbers.Add(res);
        //        listNumbers.Add(temp);
        //    }
        //    else if (btn == "btnDivClicked")
        //    {
        //        res = Div();
        //        listNumbers.Clear();
        //        listNumbers.Add(res);
        //        listNumbers.Add(temp);
        //    }

        //    return res;
        //}
    }
}
