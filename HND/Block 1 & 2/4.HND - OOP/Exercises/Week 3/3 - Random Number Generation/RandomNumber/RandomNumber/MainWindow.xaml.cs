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

namespace RandomNumber
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

        private void btn_Roll_Click(object sender, RoutedEventArgs e)
        {
            Random randomInteger = new Random();

            txtblk_Result.Text = "";

            // loop 20 times
            for (int counter = 1; counter <= 20; counter++)
            {
                // pick random integer between 1 and 6
                int nextValue = randomInteger.Next(1, 7);

                txtblk_Result.Text += nextValue + "     "; // append value to output

                // add a new line after every 5 values displayed
                if (counter % 5 == 0) // modulus operator returns only remainder value of division
                    txtblk_Result.Text += "\n";
            }
        }
    }
}
