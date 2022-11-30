using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms.Projects.Project1.Class
{
    public class Number
    {
        string _number;
        public string number{             
            
            get{ return _number; }
            
            set
            {
               if(value.Length == 3)
               {
                    _number = value;                         
               }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Sayı 3 haneli olmalıdır.");
                    Application.Restart();
                }
            }
        }
    }
}
