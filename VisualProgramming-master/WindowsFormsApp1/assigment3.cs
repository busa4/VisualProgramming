using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class assigment3 : Form
    {
        public assigment3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isint1 = int.TryParse(textBox1.Text, out int w);
            bool isint2 = int.TryParse(textBox1.Text, out int h);

            if (isint1 && isint2 == true)
            {
                double bmi = w / Math.Sqrt(h);
                 
                label3.Text = String.Format("BMI: {0}  \n Status: {1}", bmi, bmi < 18.5 ? "underweight" : bmi <= 25 ? "optimal" : "overweight");
            }
        }
    }
}
