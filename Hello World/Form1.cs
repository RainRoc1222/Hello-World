using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hello_World.Properties;
namespace Hello_World
{
    public partial class Form1 : Form
    {
        private int sec = 1000;
     
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSay_Click(object sender, EventArgs e)
        {
            labelHelloWorld.Text = "Hello World!";
        }

        private async void Count_Click(object sender, EventArgs e)
        {
          
            for (int i = 0; i <= 10; i++)
            {
                await Task.Delay(sec);
                labelCount.Text = i.ToString();
               
            }
        }




        private async void Form1_Load(object sender, EventArgs e)
        {
            bool IsNow = false;

            //解法一
            while (!IsNow)
            {
                await Task.Delay(sec);
                labelTime.Text = DateTime.Now.ToString();
            }

            //解法二
            //do
            //{
            //    await Task.Delay(sec);
            //    labelTime.Text = DateTime.Now.ToString();
            //}
            //while (!IsNow);

            //解法三
            //for(int i = 0; i <= 0; i++)
            //{
            //    await Task.Delay(sec);
            //    labelTime.Text = DateTime.Now.ToString();
            //    i--;
            //}
        }

    }
}
