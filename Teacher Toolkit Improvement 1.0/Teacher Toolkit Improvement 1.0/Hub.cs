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
    public partial class Hub : Form
    {
        public Hub()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new TourOfTheToolkit();
            newForm.Show();
            this.Close();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new DiceRoll();
            newForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new RandomNumberGen();
            newForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newForm = new StudentGen();
            newForm.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://kahoot.com/");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.utcsheffield.org.uk/olp/");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var newForm = new StopwatchTimer();
            newForm.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
