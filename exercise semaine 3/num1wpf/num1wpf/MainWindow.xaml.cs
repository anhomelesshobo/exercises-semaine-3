using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace num1wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool bascule = false;
        object IsThreeState = null;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            Debug.Write("cocher!\n");
            IsThreeState = 1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Debug.Write("Button Cliker!\n");
        }

       

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            Debug.Write("Button maintenue!\n");
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            

                Debug.Write("Button Bascule a ON!\n");
                bascule = true;
            
          
            
        }
      

        private void UnCheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            Debug.Write("Button Bascule a OFF!\n");
            bascule = false;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Unchecked_1(object sender, RoutedEventArgs e)
        {
            IsThreeState = false;
            Debug.Write("Decocher!\n");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Debug.Write("Allo je suis le premier RadioBox\n");
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            Debug.Write("Allo je suis le deuxieme RadioBox\n");
        }
    }
}
