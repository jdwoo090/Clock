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
    public partial class Timer : Form
    {
        int time;
        int time2;
        int time3;
        int time11;
        int time22;
        int time33;

        Boolean timeDone = false;

        public Timer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                time = int.Parse(comboBox3.Text);
                time2 = int.Parse(comboBox2.Text);
                time3 = int.Parse(comboBox1.Text);

                time11 = time;
                time22 = time2;
                time33 = time3;

                label1.Text = time3.ToString("D2") + ":" + time2.ToString("D2") + ":" + time.ToString("D2");

                label1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;

                button1.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;

                timer2.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure to assign a value to the seconds!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Timer_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(comboBox1.Text) < 60 && int.Parse(comboBox2.Text) < 60 && int.Parse(comboBox3.Text) < 60)
                {
                    button1.Enabled = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time = time - 1;

            if (time == 0 && time2 == 0 && time3 == 0)
            {
                timer2.Enabled = false;

                    for (int i = 0; i < 5; i++)
                    {
                        Console.Beep(500, 500);
                        System.Threading.Thread.Sleep(250);
                    }
                MessageBox.Show("The Alarm is done.", "I'm Done!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                if (time2 == 00 && time3 == 00)
                {
                    //test
                }
                else
                {
                    if (time == 00)
                    {
                        time2 = time2 - 1;
                        time = 59;
                    }
                    if (time2 == 00 && time3 != 00)
                    {
                        time3 = time3 - 1;
                        time2 = 59;
                    }
                }
            }

            label1.Text = time3.ToString("D2") + ":" + time2.ToString("D2") + ":" + time.ToString("D2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Pause")
            {
                timer2.Enabled = false;
                button3.Text = "Resume";
            }
            else
            {
                timer2.Enabled = true;
                button3.Text = "Pause";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Resume")
            {
                button3.Text = "Start";
            }

            time = time11;
            time2 = time22;
            time3 = time33;

            label1.Text = time3.ToString("D2") + ":" + time2.ToString("D2") + ":" + time.ToString("D2");
        }
    }
}
