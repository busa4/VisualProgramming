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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Form1 f1 = new Form1();;
            f1.ShowDialog();
                //123
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tickets f2 = new Tickets();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            assigment3 f3 = new assigment3();
            f3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            factorial f4 = new factorial();
            f4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            game5 g5 = new game5();
            g5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ass6 ass6 = new ass6();
            ass6.ShowDialog();
        }
    }
}
