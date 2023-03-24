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

        private void txtL649_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnL649Gen_Click(object sender, EventArgs e)
        {
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
                txtL649.Text += num.ToString() + Environment.NewLine;
            }

            // open file for writing
            StreamWriter lottoFile = new StreamWriter("LottoNbrs.txt",true);

            lottoFile.Write("649, "+DateTime.Now.ToString("yyyy'/'MM'/'dd HH:mm:ss tt") +",\t");
            // store list to text file
            for (int i = 0; i < 6; i++)
            {
                lottoFile.Write(generatedNum[i]);
                if (i < 5)
                {
                    lottoFile.Write(",");
                }
            }
            lottoFile.WriteLine("\tBonus {0}",lastItem.ToString());
            lottoFile.Close();
        }

        private void btn649Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application? ", "Exit ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
