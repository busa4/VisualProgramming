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
    public partial class ass6 : Form
    {
        public ass6()
        {
            InitializeComponent();
        }
        int randInt = 0;

        private void ass6_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            randInt = rnd.Next(1,4);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            play(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            play(2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            play(3);

        }
        private int increse(int i)
        {
            if (i == 3) {
                return 1;
            }
            int e = i + 1;
            return e;
        }
        private void play(int playerChose)
        {
            
            if (playerChose == randInt) {
                MessageBox.Show("Draw");
            }
            else if (increse(playerChose) == randInt)
            {
              MessageBox.Show("You Win");
            }
            else {
                MessageBox.Show("You Lose");
            }
        }
    }
}
