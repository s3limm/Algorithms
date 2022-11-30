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

        string ones;
        string tens;
        string hundreds;
        

        private void DigitsCheck(int numbers)
        {
            for (int i = 1; i <= 3; i++)
            {
             
            }
        }
        private void btnCheck_Click_1(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtNumbers.Text);
            DigitsCheck(number);
        }
    }
}
