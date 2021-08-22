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

namespace PassingParameters
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

        // x passed by reference and and method modifies original
        // variable's value
        void SquareRef(ref int x)
        {
            x = x * x;
        }

        // x passed as out parameter and method intialises 
        // and modifies original variable's value
        void SquareOut(out int x)
        {
            x = 6;
            x = x * x;
        }

        // x passed by value and method cannot modify 
        // original variable's value
        void Square(int x)
        {
            x = x * x;
        }

        private void btn_Result_Click(object sender, RoutedEventArgs e)
        {
            int y = 5; // create a  new int and intialise to value 5
            int z; // declare z, but do not initialise

            //display the original/starting values of y and z
            txtblk_Result.Text = "Starting value of y: " + y + "\n";

            txtblk_Result.Text += "Starting value of z: uninitialised " + "\n"; 
        
            // pass y and z by reference
            SquareRef(ref y);
            SquareOut(out z);

            //display values of y and z after modified by methods
            // SquareRef and SquareOut
            txtblk_Result.Text += "Value of y after SquareRef: " + y + "\n";
            txtblk_Result.Text += "Value of z after SquareOut: " + z + "\n";

            // pass y and z by value
            Square(y);
            Square(z);

            // display values of y and z after being passed by value
            // note they are unchanged
            txtblk_Result.Text += "Value of y after Square: " + y + "\n";
            txtblk_Result.Text += "Value of z after Square: " + z + "\n";
        
        }
    }
}
