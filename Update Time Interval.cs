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
    public partial class Update_Time_Interval : Form
    {
        public Update_Time_Interval()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
        //    try
        //    {
        //        Form1 f1 = new Form1();

        //        f1.time_interval = int.Parse(textBox1.Text);

        //        this.Close();
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Please only include numbers");
        //    }
        }
    }
}
