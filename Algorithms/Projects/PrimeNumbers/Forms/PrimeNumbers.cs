using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms.Projects.PrimeNumbers.Forms
{
    public partial class PrimeNumbers : Form
    {
        public PrimeNumbers()
        {
            InitializeComponent();
        }

        bool result = true;
        int sayac = 0;

        public void CheckNumbers(int numbers)
        {
            for (int i = 2; i <= numbers - 1; i++)
            {
                if (numbers % i == 0)
                {
                    result = false;
                    break;
                }
            }

            if (result == true)
            {
                lblNumber.Text = $"{numbers} asal sayıdır.";
                PrintFiveNumbers(numbers);
            }
            else
            {
                lblNumber.Text = $"{numbers} asal değildir.";
            }
        }

        public void PrintFiveNumbers(int _numbers)
        {
            int sayac = 0;
            bool result2 = true;
            int n1 = _numbers - 1;

            do
            {
                _numbers++;

                for (int i = 2; i < _numbers - 1; i++)
                {
                    if (_numbers % i == 0)
                    {
                        result2 = false;
                        break;
                    }


                }
                
                if (result2 == true)
                {
                    sayac++;
                    lstNumbers.Items.Add(_numbers);
                }
            }
            while (sayac <= 5);

        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            Number number = new Number();
            number.number = Convert.ToInt32(txtNumbers.Text);
            CheckNumbers(number.number);
        }
    }
}
