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
    public partial class Tickets : Form
    {
        public Tickets()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Tickets_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void resulta_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool b1 = int.TryParse(textBox1.Text, out int classa);
            bool b2 = int.TryParse(textBox2.Text, out int classb);
            bool b3 = int.TryParse(textBox3.Text, out int classc);

            if (b1 && b2 && b3 == true)
            {
                resulta.Text = (classa * 15).ToString() + " $";
                resultb.Text = (classb * 12).ToString() + " $";
                resultc.Text = (classc * 9).ToString() + " $";
                resultt.Text = (classa * 15 + classb * 12 + classc * 9).ToString() + " $";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resulta.Text = "";
            resultb.Text = "";
            resultc.Text = "";
            resultt.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }
    }
}
