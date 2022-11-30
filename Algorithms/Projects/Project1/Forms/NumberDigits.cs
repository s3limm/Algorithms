using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms
{
    public partial class NumberDigits : Form
    {
        public NumberDigits()
        {
            InitializeComponent();
        }

        int ones;
        int tens;
        int hundreds;

        private void DigitsCheck(int numbers)
        {
            for (int i = 1; i <= 3; i++)
            {
                numbers = numbers / 10;
                
                if(i == 1)
                {
                    ones = numbers;
                    lblOnes.Text = numbers.ToString();
                }
                else if (i == 2)
                {
                    tens = numbers;
                    lblTens.Text = numbers.ToString();
                }
                else if (i == 3)
                {
                    hundreds = numbers;
                    lblHundreds.Text= numbers.ToString();
                }
            }
        }
        private void btnCheck_Click_1(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtNumbers.Text);
            DigitsCheck(number);
        }
    }
}
