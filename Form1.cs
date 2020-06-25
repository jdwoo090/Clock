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
    public partial class Form1 : Form
    {
        Boolean dmy;
        Boolean mdy;
        Boolean ydm;
        Boolean ymd;
        Boolean myd;
        Boolean dym;

        Boolean bgChange = true;

        int h;
        int m;
        int h2;
        int m2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mdy = true;

            label1.Text = DateTime.Now.ToString().Remove(10);
            label2.Text = DateTime.Now.ToString();

            if (DateTime.Now.Hour > 1 && DateTime.Now.Hour <= 4)
            {
                BackColor = Color.Gray;
            }
            if (DateTime.Now.Hour > 4 && DateTime.Now.Hour <= 7)
            {
                BackColor = Color.LightGray;
            }
            if (DateTime.Now.Hour > 7 && DateTime.Now.Hour <= 9)
            {
                BackColor = Color.LightBlue;
            }
            if (DateTime.Now.Hour > 9 && DateTime.Now.Hour <= 12)
            {
                BackColor = Color.AliceBlue;
            }
            if (DateTime.Now.Hour > 12 && DateTime.Now.Hour <= 16)
            {
                BackColor = Color.Blue;
            }
            if (DateTime.Now.Hour > 16 && DateTime.Now.Hour <= 19)
            {
                BackColor = Color.BlueViolet;
            }
            if (DateTime.Now.Hour > 19 && DateTime.Now.Hour <= 21)
            {
                BackColor = Color.Purple;
            }
            if (DateTime.Now.Hour > 21 && DateTime.Now.Hour <= 24)
            {
                BackColor = Color.DarkGray;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bgChange == true)
            {
                if (DateTime.Now.Hour > 1 && DateTime.Now.Hour <= 4)
                {
                    BackColor = Color.Gray;
                }
                if (DateTime.Now.Hour > 4 && DateTime.Now.Hour <= 7)
                {
                    BackColor = Color.LightGray;
                }
                if (DateTime.Now.Hour > 7 && DateTime.Now.Hour <= 9)
                {
                    BackColor = Color.LightBlue;
                }
                if (DateTime.Now.Hour > 9 && DateTime.Now.Hour <= 12)
                {
                    BackColor = Color.AliceBlue;
                }
                if (DateTime.Now.Hour > 12 && DateTime.Now.Hour <= 16)
                {
                    BackColor = Color.Blue;
                }
                if (DateTime.Now.Hour > 16 && DateTime.Now.Hour <= 19)
                {
                    BackColor = Color.BlueViolet;
                }
                if (DateTime.Now.Hour > 19 && DateTime.Now.Hour <= 21)
                {
                    BackColor = Color.Purple;
                }
                if (DateTime.Now.Hour > 21 && DateTime.Now.Hour <= 24)
                {
                    BackColor = Color.DarkGray;
                }
            }
                if (mdy == true)
            {
                label1.Text = DateTime.Now.ToString().Remove(10);
                label2.Text = DateTime.Now.ToString();
            }
            if (dmy == true)
            {
                label1.Text = DateTime.Now.ToString("dd/MM/yyyy");
                label2.Text = DateTime.Now.ToString();
            }
            if (ydm == true)
            {
                label1.Text = DateTime.Now.ToString("yyyy/dd/MM");
                label2.Text = DateTime.Now.ToString();
            }
            if (ymd == true)
            {
                label1.Text = DateTime.Now.ToString("yyyy/MM/dd");
                label2.Text = DateTime.Now.ToString();
            }
            if (myd == true)
            {
                label1.Text = DateTime.Now.ToString("MM/yyyy/dd");
                label2.Text = DateTime.Now.ToString();
            }
            if (dym == true)
            {
                label1.Text = DateTime.Now.ToString("dd/yyyy/MM");
                label2.Text = DateTime.Now.ToString();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog1.ShowDialog();

            if (d == DialogResult.OK)
            {
                label2.ForeColor = colorDialog1.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unfortunately customization of the size and font of various objects would lead to errors and issues with readability and as such is not able to be changed currently...", "Font/Size", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the MWEProductions timer, clock and general date manager! This program well help you manage your time better and always be aware of the date and time! For various customizability settings, look elsewhere in the menu. Click on the timer button for a timer. Other than that, any further questions or issues can be directed to the original coder.", "Other", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ddmmyyyyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdy = false;
            dmy = true;
            ydm = false;
            ymd = false;
            myd = false;
            dym = false;
        }

        private void mmddyyyyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdy = true;
            dmy = false;
            ydm = false;
            ymd = false;
            myd = false;
            dym = false;
        }

        private void yyyyddmmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ydm = true;
            dmy = false;
            mdy = false;
            ymd = false;
            myd = false;
            dym = false;
        }

        private void ddyyyymmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdy = false;
            dmy = false;
            ydm = false;
            ymd = false;
            myd = false;
            dym = true;
        }

        private void mmyyyyddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdy = false;
            dmy = false;
            ydm = false;
            ymd = false;
            myd = true;
            dym = false;
        }

        private void yyyymmddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdy = false;
            dmy = false;
            ydm = false;
            ymd = true;
            myd = false;
            dym = false;
        }

        private void backgroundSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dd = MessageBox.Show("This program updates the background color based on the time of day. You may force the background to another color, but this will disable the background timer for this session to avoid errors. Do you want to forcefully change the background?", "Background Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dd == DialogResult.Yes)
            {
                DialogResult ddd = colorDialog1.ShowDialog();

                if (ddd == DialogResult.OK)
                {
                    this.BackColor = colorDialog1.Color;
                    bgChange = false;
                }
            }
        }

        private void timeUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dd = MessageBox.Show("This program updates the time and date every second. You may make it update at a different speed (updating by 5 seconds, 10 seconds, etc.), changing the amount of processing power needed, but changing this may cause accuracy errors or may not be as efficient. Do you want to change the update intervals?", "Time Updates", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dd == DialogResult.Yes)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                menuStrip1.Visible = false;
                label4.Visible = true;
                textBox1.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            menuStrip1.Visible = true;
            label4.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(textBox1.Text);

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            menuStrip1.Visible = true;
            label4.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Be aware that this alarm will be lost if the program is closed.", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Information);

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            menuStrip1.Visible = false;
            label6.Visible = true;
            button7.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            label5.Visible = true;
            button6.Visible = true;
            comboBox3.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Timer tm = new Timer();
            tm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            h2 = int.Parse(comboBox1.Text);
            m2 = int.Parse(comboBox2.Text);

            if (comboBox3.Text == "PM")
            {
                h2 = h2 + 12;
            }

            if (DateTime.Now.Hour > h2 || DateTime.Now.Minute > m2)
            {
                MessageBox.Show("Please enter a time in the future (alarms only count for the current day due to the fact the alarm is lost at the program's closing, as such, if you set the alarm for a time tomorrow (starting when 11:59 pm goes 12 am from this current day), then it won't work. Sorry for the inconvenience.)", "That's in the past!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                timer3.Enabled = true;

                button3.Enabled = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                h = int.Parse(comboBox1.Text);
                m = int.Parse(comboBox2.Text);

                if (comboBox3.Text == "PM")
                {
                    h = h + 12;
                }

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                menuStrip1.Visible = true;

                label6.Visible = false;
                button7.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                label5.Visible = false;
                button6.Visible = false;
                comboBox3.Visible = false;

                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;

                if (DateTime.Now.Hour == h && DateTime.Now.Minute == m)
                {
                    timer3.Enabled = false;
                    button3.Enabled = true;

                    for (int i = 0; i < 5; i++)
                    {
                        Console.Beep(500, 500);
                        System.Threading.Thread.Sleep(250);
                    }
                    MessageBox.Show("The Alarm is done.", "I'm Done!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure to actually enter a time!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                timer3.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            menuStrip1.Visible = true;

            label6.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            label5.Visible = false;
            button6.Visible = false;
            comboBox3.Visible = false;
            button7.Visible = false;

            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
        }
    }
}
