using Algorithms.Projects.Project1.Class;
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

        int ones = 0;
        int tens = 0;
        int hundreds = 0;
        int mod1;
        int mod2;


        public void DigitsCheckProcess(int numbers)
        {           
            if(numbers.ToString().Length == 3) 
            {
                if (numbers % 100 == 0)
                {
                    hundreds = numbers / 100;
                    DigitsShowProcess(ones, tens, hundreds);
                }
                else
                {
                    mod1 = numbers % 100;
                    numbers = numbers - mod1;
                    hundreds = numbers / 100;

                    if (mod1 % 10 == 0)
                    {
                        tens = mod1 / 10;
                        DigitsShowProcess(ones, tens, hundreds);
                    }
                    else
                    {
                        mod2 = mod1 % 10;
                        mod1 = mod1 - mod2;
                        tens = mod1 / 10;
                        ones = mod2;
                        DigitsShowProcess(ones, tens, hundreds);
                    }
                }
            }

            else
            {
                MessageBox.Show("Lütfen 3 basamaklı bir sayı giriniz.");
                Application.Restart();
            }

            
        }

        public void DigitsShowProcess(int ones, int tens, int hundreds)
        {
            lblOnes.Text = $"Birler Basamağı : {ones.ToString()}";
            lblTens.Text = $"Onlar Basamağı : {tens.ToString()}"; ;
            lblHundreds.Text = $"Yüzler Basamağı : {hundreds.ToString()}"; ;

        }



        private void btnCheck_Click_1(object sender, EventArgs e)
        {
            Number numbers = new Number();
            numbers.number = Convert.ToInt32(txtNumbers.Text);
            DigitsCheckProcess(numbers.number);
        }
    }
}
