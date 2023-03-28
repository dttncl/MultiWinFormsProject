using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    internal class ConvertTemp
    {
        // fields
        private decimal temp;

        // constructor
        public ConvertTemp()
        {

        }

        public ConvertTemp(decimal temp)
        {
            Temp = temp;
        }

        // property
        public decimal Temp
        {
            get {return temp; }
            set {temp = value; }
        }

        // methods
        public decimal ConvertToCelcius()
        {
            return Math.Round((Temp - 32) * 5 / 9,1);
        }

        public decimal ConvertToFarenheit()
        {
            return Math.Round((Temp * 9 / 5) + 32,1);
        }

        public string DescribeTemperature(char unitFrom)
        {
            // use temp in celsius for the evaluation
            if(unitFrom != 'C')
            {
                Temp = ConvertToCelcius();
            }

            string desc = "";

            if(Temp >= 100)
            {
                desc += "Water Boils";
            }
            else if(Temp<100 && Temp>=40)
            {
                desc += "Hot Bath";
            }
            else if (Temp < 40 && Temp >= 37)
            {
                desc += "Body Temperature";
            }
            else if (Temp < 37 && Temp >= 30)
            {
                desc += "Beach Weather";
            }
            else if (Temp < 30 && Temp >= 21)
            {
                desc += "Room Temperature";
            }
            else if (Temp < 21 && Temp >= 10)
            {
                desc += "Cool Day";
            }
            else if (Temp < 10 && Temp >= 0)
            {
                desc += "Freezing Point of Water";
            }
            else if (Temp < 0 && Temp >= -18)
            {
                desc += "Very Cold Day";
            }
            else if (Temp < -18)
            {
                desc += "Extremely Cold Day";
                if(Temp == -40)
                {
                    desc += "\n(and the same number!)";
                }
            }

            return desc;
        }

    }
}
