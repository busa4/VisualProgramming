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
    public partial class Project : Form
    {

        public Project()
        {
            InitializeComponent();
            InitializePictureBoxes();
            HidePictureBoxes();
        }
        private PictureBox[] pictureBoxes;

        private void InitializePictureBoxes()
        {
            pictureBoxes = new PictureBox[]
            {
            pictureBox2, pictureBox3, pictureBox4, pictureBox5,
            pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10
            };
        }
        private int gameTimeInSeconds = 30;

        private bool gameGoes = false;
        private void HidePictureBoxes()
        {
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            pictureBox10.Hide();
        }
            private void ShowRandomPictureBox()
        {
            Random random = new Random();
            int randomIndex = random.Next(pictureBoxes.Length);

            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.Hide();
            }

            pictureBoxes[randomIndex].Show();
        }
        private void IncrementLabel()
        {
            int currentValue = int.Parse(label2.Text);
            currentValue++;
            label2.Text = currentValue.ToString();
        }
        private void EndGame()
        {
            gameGoes = false;
            HidePictureBoxes();
            MessageBox.Show("You Score is: " + label2.Text, "Result");
            label2.Text = "0";

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            gameGoes = true;
            ShowRandomPictureBox();
            await StartCountdownAsync();
            if (gameGoes)
            {
                EndGame();
            }
        }
        private async Task StartCountdownAsync()
        {
            // Инициализация начального значения времени в label4
            label4.Text = gameTimeInSeconds.ToString();

            // Запуск асинхронного цикла отсчета времени
            while (gameTimeInSeconds > 0 && gameGoes)
            {
                // Подождать 1 секунду
                await Task.Delay(1000);

                // Уменьшить время на 1 секунду
                gameTimeInSeconds--;

                // Обновить значение времени в label4
                label4.Text = gameTimeInSeconds.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            EndGame();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            IncrementLabel();
            pictureBox2.Hide();
            ShowRandomPictureBox();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            IncrementLabel();
            pictureBox3.Hide();
            ShowRandomPictureBox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            IncrementLabel();
            pictureBox4.Hide();
            ShowRandomPictureBox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            IncrementLabel();
            pictureBox5.Hide();
            ShowRandomPictureBox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            IncrementLabel();
            pictureBox9.Hide();
            ShowRandomPictureBox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            IncrementLabel();
            pictureBox10.Hide();
            ShowRandomPictureBox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            IncrementLabel();
            pictureBox6.Hide();
            ShowRandomPictureBox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            IncrementLabel();
            pictureBox7.Hide();
            ShowRandomPictureBox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            IncrementLabel();
            pictureBox8.Hide();
            ShowRandomPictureBox();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
