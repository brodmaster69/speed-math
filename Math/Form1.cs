using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math
{
    public partial class frmMain : Form
    {
        public int timeLeft;
        public int a, b;

        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doneButton.Enabled = false;
            startButton.Enabled = true;
            timer1.Stop();

            int c = a + b;
            if (answerBox.Text == c.ToString())
            {
                timer1.Stop();
                timeLable.Text = "correct";
            }
            else
            {
                timeLable.Text = "you suck";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timeLeft = 5;
            Random r = new Random();
            a = r.Next(12) + 1;
            b = r.Next(12) + 1;
            aLabel.Text = a.ToString();
            bLable.Text = b.ToString();

            timer1.Start();

            startButton.Enabled = false;
            doneButton.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                timeLable.Text = timeLeft.ToString();
            }
            if (timeLeft == 0)
            {
                doneButton.Enabled = false;
                startButton.Enabled = true;
                timer1.Stop();
                timeLable.Text = "";
            }
        }
    }
}
