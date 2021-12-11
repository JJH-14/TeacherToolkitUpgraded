using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher_Toolkit_Improvement_1._0
{
    public partial class DiceRoll : Form
    {
        public DiceRoll()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 6 + 1);
            textBox2.Text = dice1.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 12 + 1);
            textBox3.Text = dice1.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 18 + 1);
            textBox4.Text = dice1.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 24 + 1);
            textBox5.Text = dice1.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 30 + 1);
            textBox6.Text = dice1.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            var newForm = new Hub();
            newForm.Show();
            this.Close();
        }
    }
}
