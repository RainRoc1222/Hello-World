using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    internal class Test : ITest
    {

        public  async  void Count(int sec,Label labelCount)
        {
            for (int i = 0; i <= 10; i++)
            {
                await Task.Delay(sec);
                labelCount.Text = i.ToString();

            }
        }
        public async void Count(int sec, Label labelTime,bool IsTrue)
        {
            while (IsTrue)
            {
                await Task.Delay(sec);
                labelTime.Text = DateTime.Now.ToString();
            }
        }
    }
}
