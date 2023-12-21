using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class asgmt7 : Form
    {
        string[] lines;
        string[] correctAnswers = {"B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A"};
        public asgmt7()
        {
            InitializeComponent();
            string filePath = Path.Combine(Application.StartupPath, "Resources", "answers.txt");

            try
            {
                if (File.Exists(filePath))
                {
                    lines = File.ReadAllLines(filePath);
                }
                else
                {
                    MessageBox.Show("Файл answers.txt не найден в папке Resources. " + filePath, "Ошибка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при чтении файла: {ex.Message}", "Ошибка");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int correct = 0;
            List<int> correctsList = new List<int>();
            for (int i = 0; i < correctAnswers.Length; i++)
            {
                if (lines[i] == correctAnswers[i])
                {
                    correct++;
                    correctsList.Add(i);
                }
            }
            string cAnswers = string.Join(", ", correctsList);
            MessageBox.Show(correct > 15 ? "Passed" : "Failed" + "\nYou correct answers is " + correct + 
                "\nПравельные ответы: " + cAnswers
                , "Результат");
        }
    }
}
