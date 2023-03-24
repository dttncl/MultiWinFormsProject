using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProject
{
    public partial class frm649 : Form
    {
        public frm649()
        {
            InitializeComponent();
        }

        private void btnL649Gen_Click(object sender, EventArgs e)
        {
            // BASIC FUNCTION
            // clear the textbox if button is clicked
            txtL649.Clear();

            var generatedNum = new List<int>();
            Random random = new Random();

            // generate random numbers from 0 to 9
            string randomNumber = random.Next(0, 9).ToString();
            for (int i = 0; i < 6; i++)
            {
                randomNumber += random.Next(0, 9).ToString();
            }

            lbl64909.Text = randomNumber;

            // generate first number and add to list
            int firstRNum = random.Next(1, 49);
            generatedNum.Add(firstRNum);

            // generate a new number and add to list
            int newRNum;
            for (int i = 0; i < 6; i++)
            {
                
                // generate a new number while it exists in the list
                // validation to ensure that every number is unique
                do
                {
                    newRNum = random.Next(1, 49);
                } while (generatedNum.Contains(newRNum));
                
                generatedNum.Add(newRNum);
            }

            // store the last generated number as bonus
            var lastItem = generatedNum.Last();

            // display list
            foreach (int num in generatedNum)
            {
                txtL649.Text += num.ToString() + "\r\n";
            }

            // WRITE TO TEXT FILE
            string outputDesc = $"{",",-5}";
            for (int i = 0; i < 6; i++)
            {
                // position the commas
                outputDesc += generatedNum[i];
                if (i < 5)
                {
                    outputDesc += ",";
                }
            }

            outputDesc += $"{"Bonus",8} {lastItem}";

            DataStream toWrite = new DataStream();

            toWrite.FileName = "LottoNbrs";
            toWrite.MsgBoxTitle = "Lotto649";
            toWrite.Output = "649";
            toWrite.Description = outputDesc;

            toWrite.WriteFile();


        }

        private void btn649Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close this window? ", "Close Lotto 649", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnL649Read_Click(object sender, EventArgs e)
        {
            // READ TEXT FILE
            DataStream toRead = new DataStream();

            toRead.FileName = "LottoNbrs";
            toRead.MsgBoxTitle = "Lotto649";

            toRead.ReadFile();
        }
    }
}
