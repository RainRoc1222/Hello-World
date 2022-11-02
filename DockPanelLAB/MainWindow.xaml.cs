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

namespace DockPanelLAB
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ShowIMG_Click(object sender, RoutedEventArgs e)
        {

            Griddd.Resources.Clear();
           

      

            for(int i = 0; i <= 3; i++)
            {
                RowDefinition row = new RowDefinition();
                ColumnDefinition col = new ColumnDefinition();
                Griddd.RowDefinitions.Add(row);
                Griddd.ColumnDefinitions.Add(col);
                for (int j = 0; j <= 3; j++)
                {
                    DockPanel dockPanel = new DockPanel();  
                 
                   
                    TextBlock textBlock = new TextBlock()
                    {
                        Background = new SolidColorBrush(Colors.Red),
                        //Width = 100,
                        //Height = 10,
                                            
                    };
                    TextBlock textBlock2 = new TextBlock()
                    {
                        Background = new SolidColorBrush(Colors.Red),
                        Width = 10,
                        Height = 100,

                    };
                    if(i%2==0 && j % 2 != 0)
                    {
                        DockPanel.SetDock(textBlock, Dock.Top);
                        DockPanel.SetDock(textBlock2, Dock.Left);
                    }
                    else
                    {
                        DockPanel.SetDock(textBlock, Dock.Bottom);
                        DockPanel.SetDock(textBlock2, Dock.Right);
                    }
                    
                    dockPanel.Children.Add(textBlock);
                    dockPanel.Children.Add(textBlock2);
                    

                    
                    Griddd.Children.Add(dockPanel);
                    Grid.SetRow(dockPanel, i);
                    Grid.SetColumn(dockPanel, j);
                 

                }


            }
        }
    }
}
