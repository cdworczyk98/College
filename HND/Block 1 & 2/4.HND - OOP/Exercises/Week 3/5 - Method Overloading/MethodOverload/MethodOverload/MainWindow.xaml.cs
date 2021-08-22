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

namespace MethodOverload
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

        // first version, takes 1 integer
        public int Square(int x)
        {
            return x * x;
        }

        // second version, takes 1 double
        public double Square(double y)
        {
            return y * y;
        }

        private void btn_Result_Click(object sender, RoutedEventArgs e)
        {
            // call both versions of Square and display
            // results in the text block
            txtblk_Result.Text = "The square of integer 7 is " + Square(7) + "\n The square of double 7.5 is " + Square(7.5);

        }
    }
}
