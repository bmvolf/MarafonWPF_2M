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
using System.Windows.Threading;

namespace Task_04
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {

            Label.Content = i.ToString();
            i += 1;
            if(i >= 30)
            {
                i = 30;
            }
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            DispatcherTimer tmr = new DispatcherTimer();
            tmr.Tick += Tmr_Tick;
            tmr.Interval = TimeSpan.FromMilliseconds(1000);
            tmr.Start();
        }
    }
}
