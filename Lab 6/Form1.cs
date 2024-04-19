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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(tbMin.Text);
            int max = Convert.ToInt32(tbMax.Text);
            Form2.SetGameSettings(min, max, comboDifficulty.SelectedItem.ToString());
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboDifficulty.SelectedIndex = 0; // Set default difficulty to Easy
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the entire application
            Application.Exit();
        }
    }
}
