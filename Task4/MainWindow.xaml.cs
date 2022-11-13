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

namespace Task4
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

        public static int Div(int a, int b, bool isModule)
        {
            if(b == 0)
            {
                return -1;
            }

            if(isModule)
            {
                return a % b;
            } else
            {
                return a / b;
            }
            
        }

        public static double pow(int a, int b)
        {
            return Math.Pow(a, b);
        }

        public static string concat(int a, int b)
        {
            return Convert.ToString(a) + Convert.ToString(b);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int intValue1 = Convert.ToInt32(value1.Text);
            int intValue2 = Convert.ToInt32(value2.Text);
            if (radioButton1.IsChecked == true)
            {
                if(Div(intValue1, intValue2, true) == -1)
                {
                    result.Text = "На ноль делить нельзя";
                } else
                {
                    result.Text = Convert.ToString(Div(intValue1, intValue2, true));
                }
            }

            if (radioButton2.IsChecked == true)
            {
                result.Text = Convert.ToString(pow(intValue1, intValue2));
            }

            if (radioButton3.IsChecked == true)
            {
                result.Text = Convert.ToString(concat(intValue1, intValue2));
            }

            if (radioButton4.IsChecked == true)
            {
                if (Div(intValue1, intValue2, false) == -1)
                {
                    result.Text = "На ноль делить нельзя";
                }
                else
                {
                    result.Text = Convert.ToString(Div(intValue1, intValue2, false));
                }
            }
        }
    }
}
