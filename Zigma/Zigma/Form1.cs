using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zigma
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
          

        }
        bool errors;
        private void btn_submit_Click(object sender, EventArgs e)
        {
            double a, r, n;
            a = r = n = 0;
            double s = 0;
            

          
            if (txt_a.Text == "" || txt_r.Text == "" || txt_n.Text == "" || !Double.TryParse(txt_a.Text,out a
                ) || !Double.TryParse(txt_r.Text, out r) || !Double.TryParse(txt_n.Text, out n))
            {
                errors = true;
               
            }
            if(!errors)
              for(double i= 0; i < n; i++)
                {
                    s = s + (a * Math.Pow(r, i));
                    txt_s.Text = s.ToString();
                }
            else
            {
                MessageBox.Show("Invalid Inputs");
            }
                
            
        }
    }
}
