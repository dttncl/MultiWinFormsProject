using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

// March 16, 2023
// Money Conversion Factors (based on 1CAD):
// Source: Royal Bank of Canada
// 0.71230 USD
// 0.66609 EUR
// 0.58333 GBP
// 38.22630 PHP

namespace WinFormProject
{
    internal class CurrencyEx
    {
        // field
        private decimal amt;

        // constructor
        public CurrencyEx()
        {

        }

        public CurrencyEx (decimal amt)
        {
            Amt = amt;
        }

        // property
        public decimal Amt
        {
            get { return amt; }
            set { amt = value; }
        }

        // methods or functions
        // convert any currency to CAD
        public decimal ConvertToCAD (string currencyFrom)
        {
            decimal mul;

            switch(currencyFrom)
            {
                case "USD":
                    mul = 0.71230M;
                    break;
                case "EUR":
                    mul = 0.66609M;
                    break;
                case "GBP":
                    mul = 0.58333M;
                    break;
                case "PHP":
                    mul = 38.22630M;
                    break;
                default:
                    mul = 1;
                    break;
            }

            decimal convCAD = Amt / mul;
            return convCAD;
        }

        // covert from CAD to any currency
        public decimal ConvertToCurrency(decimal convCAD, string currencyTo)
        {
            decimal mul;

            switch (currencyTo)
            {
                case "USD":
                    mul = 0.71230M;
                    break;
                case "EUR":
                    mul = 0.66609M;
                    break;
                case "GBP":
                    mul = 0.58333M;
                    break;
                case "PHP":
                    mul = 38.22630M;
                    break;
                default:
                    mul = 1;
                    break;
            }

            decimal convAmt = convCAD * mul;
            return convAmt;
        }
    }
}
