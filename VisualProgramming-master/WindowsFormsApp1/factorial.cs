using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class factorial : Form
    {
        public factorial()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isint1 = int.TryParse(textBox1.Text, out int intager);
            if (isint1 && intager > 0)
            {
                int result = calculateFactorial(intager);
                MessageBox.Show(result.ToString(), "calculated");

            }
            
        }
        private int calculateFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * calculateFactorial(number - 1);
        }
    }
}
