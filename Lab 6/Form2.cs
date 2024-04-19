using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Form2 : Form
    {

        private static int goalNumber;
        private static int remainingTime;
        private static Timer timer;

        public Form2()
        {
            InitializeComponent();
        }

        public static void SetGameSettings(int min, int max, string difficulty)
        {
            Random rand = new Random();
            goalNumber = rand.Next(min, max + 1);

            switch (difficulty)
            {
                case "Easy":
                    remainingTime = 70;
                    break;
                case "Medium":
                    remainingTime = 60;
                    break;
                case "Hard":
                    remainingTime = 40;
                    break;
                default:
                    remainingTime = 60; // Default to medium if difficulty is invalid
                    break;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int guess = Convert.ToInt32(txtEnterNumber.Text);

            if (guess > goalNumber)
                MessageBox.Show("Guess lower!");
            else if (guess < goalNumber)
                MessageBox.Show("Guess higher!");
            else
            {
                MessageBox.Show("Congratulations! You won!");
                timer.Stop();
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblTimer.Text = remainingTime.ToString();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            lblTimer.Text = "Time Left: " + remainingTime.ToString();

            if (remainingTime <= 0)
            {
                timer.Stop();
                MessageBox.Show("Time's up! You lost.");
                this.Close();
            }
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 form1 = new Form1();
            form1.Show();
        }

    }
}
