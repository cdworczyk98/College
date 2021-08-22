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

namespace InitArrays
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

        private void btn_Result_Click(object sender, RoutedEventArgs e)
        {
            txtblk_Result.Text = "";

            int[] array1;  // declare reference to an array

            array1 = new int[10]; // dynamically allocate array and set default values

            // initialiser list specifies number of elements and value of each element
            int[] array2 = { 32, 27, 64, 18, 95, 14, 90, 70, 60, 37};

            const int ARRAY_SIZE = 10;
            int[] array3;

            // allocate array of ARRAY_SIZE elements
            array3 = new int[ARRAY_SIZE];

            // set the vaules in the array
            for (int i = 0; i < array3.Length; i++)
                array3[i] = 2 + 2 * i;

            txtblk_Result.Text += "Subscript \tArray 1\tArray 2\tArray 3\n";

            //output values for each array
            for (int i = 0; i < ARRAY_SIZE; i++)
                txtblk_Result.Text += i + "\t\t" + array1[i] + "\t" + array2[i] + "\t" + array3[i] + "\n";


         
        }
    }
}
