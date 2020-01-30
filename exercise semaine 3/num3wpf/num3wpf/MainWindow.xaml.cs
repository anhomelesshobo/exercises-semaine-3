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

namespace num3wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myProgressBar.Value = 0;

            Task.Run(() =>

            {

                for (int i = 0; i < 10; i++)

                {

                    System.Threading.Thread.Sleep(150);

                    Application.Current.Dispatcher.Invoke(() => { myProgressBar.Value += 10; });

                }

            });
        }
    }
}
