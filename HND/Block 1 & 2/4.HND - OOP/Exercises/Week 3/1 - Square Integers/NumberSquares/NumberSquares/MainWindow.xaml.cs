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

namespace NumberSquares
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
        
        // method that takes in a value and returns the square of that value
        int Square(int y)
        {
            return y * y;

        }

        private void btn_NumberSquares_Click(object sender, RoutedEventArgs e)
        {
            txtblk_Results.Text = "";

            // loop 10 times from 1 to 10 displaying the square of each number
            for (int counter = 1; counter <= 10; counter++)
            {
                // calculate the square of the counter and store in result
                int result = Square(counter);

                // append result to the text block
                txtblk_Results.Text += "The square of " + counter + " is " + result + "\n";
            }
        }

        
    }
}
