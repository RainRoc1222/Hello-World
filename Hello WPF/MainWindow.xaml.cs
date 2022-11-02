using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Hello_WPF
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
      
        private int sec = 100;
        public ChangeProperty _ChangeProperty; 

        public MainWindow()
        {
            InitializeComponent();

            _ChangeProperty = new ChangeProperty();
            DataContext = _ChangeProperty; 
           
        }

        private void SayHello_Click(object sender, RoutedEventArgs e)
        {

            _ChangeProperty.HelloText = "Hello WPF!";
        }

        private async void ToTen_Click(object sender, RoutedEventArgs e)
        {
           
            for (int i = 0; i <= 10; i++)
            {

                await Task.Delay(sec);
                _ChangeProperty.CountText = i.ToString();
            }
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
            while (true)
            {
                await Task.Delay(sec);
                _ChangeProperty.TimeText = DateTime.Now.ToString();
            }
        }
    }
}
