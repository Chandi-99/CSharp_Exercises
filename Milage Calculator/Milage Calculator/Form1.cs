using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milage_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            bool errors = false;
            double fuel, distance, milage;
            fuel = 0.0;
            distance = 0.0;
            if(txt_fuel.Text=="" || !Double.TryParse(txt_fuel.Text,out fuel)||
                txt_distance.Text == "" || !Double.TryParse(txt_distance.Text, out fuel))
            {
                errors = true;
                MessageBox.Show("Invalid Input for fuel or distance","Error",
                    MessageBoxButtons.OKCancel);
            }

            //fuel = Convert.ToDouble(txt_fuel.Text);
            //distance = Convert.ToDouble(txt_distance.Text);
            //process
            if (!errors)
            {
                milage = distance / fuel;
                txt_milage.Text = milage.ToString();
            }
            
        }
    }
}
