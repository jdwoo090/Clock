using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpTA
{
    public partial class Stopwatch : Form
    {
        int lc = 0;
        int count = 0;
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;

        public Stopwatch()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lc = lc + 1;
            Laps.Items.Add(label1.Text + "                Lap " + lc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                timer1.Enabled = true;
                button1.Text = "Pause";
            }
            else
            {
                if (button1.Text == "Pause")
                {
                    timer1.Enabled = false;
                    button1.Text = "Resume";
                }
                else
                {
                    if (button1.Text == "Resume")
                    {
                        timer1.Enabled = true;
                        button1.Text = "Pause";
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count4 < 100)
            {
                count4 = count4 + 1;
                label1.Text = count3.ToString("D2") + ":" + count2.ToString("D2") + ":" + count.ToString("D2") + "." + count4.ToString("D2");
            }
            if (count4 == 100)
            {
                count4 = count4 - 100;
                count = count + 1;
            }
            if (count == 60)
            {
                count = count - 60;
                count2 = count2 + 1;
            }
            if (count2 == 60)
            {
                count2 = count2 - 60;
                count3 = count3 + 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Resume")
            {
                button1.Text = "Start";
            }

            count = 0;
            count2 = 0;
            count3 = 0;
            count4 = 0;

            lc = 0;

            Laps.Items.Clear();

            label1.Text = count3.ToString("D2") + ":" + count2.ToString("D2") + ":" + count.ToString("D2") + "." + count4.ToString("D2");
        }

        private void Stopwatch_Load(object sender, EventArgs e)
        {

        }
    }
}
