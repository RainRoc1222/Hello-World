using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnSay_Click(object sender, EventArgs e)
        {
            labelHelloWorld.Text = "Hello World!";
        }

        private async void Count_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= 10; i++)
            {
                await Task.Delay(1000);
                labelCount.Text = i.ToString();
            }
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString();
        }
    }
}
