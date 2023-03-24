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
    }
}
