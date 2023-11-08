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
    public partial class game5 : Form
    {
        private int random;
        private int counter = 0;

        private Random rnd = new Random();
        public game5()
        {
            InitializeComponent();
            random = rnd.Next(1, 101);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isint1 = int.TryParse(textBox1.Text, out int intager);
            if (isint1 && intager > 0 && intager < 101)
            {
                if(intager == random)
                {
                    MessageBox.Show("You won wirh " + counter.ToString() + " attemps", "result");
                    random = rnd.Next(1, 101);
                    counter = 0;
                }
                else if(intager > random)
                {
                    MessageBox.Show("Too hight, try again", "result");
                    counter++;
                }
                else
                {
                    MessageBox.Show("Too low, try again", "result");
                    counter++;
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
