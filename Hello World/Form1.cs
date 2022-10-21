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

        private  void Count_Click(object sender, EventArgs e)
        {
          
            Test test = new Test();
            test.Count(sec,labelCount);
        }




        private  void Form1_Load(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Count(sec, labelTime, true);
         
        }

    }
}
