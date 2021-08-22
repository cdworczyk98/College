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

namespace ArrayReference
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
            // create and intialise first array
            int[] firstArray = { 1, 2, 3 };

            // copy firstArray reference (we take a copy so we can see if
            // the reference has changed after being passed to the called method
            // it should only be the data changed and not the reference)
            int[] firstArrayCopy = firstArray;

            txtblk_Result.Text = "Test passing firstArray reference by VALUE (normal situtation)";

            txtblk_Result.Text += "\n\n Contents of firstArray before calling FirstDouble (doubles each elements value:\n\t";

            // print contents of firstArray
            for (int i = 0; i < firstArray.Length; i++)
                txtblk_Result.Text += firstArray[i] + " ";

            // pass reference firstArray by value to FirstDouble
            FirstDouble(firstArray);

            txtblk_Result.Text += "\n\nContents of firstArray after calling FirstDouble\n\t";

            // print contents of firstArray after being modified
            for (int i = 0; i < firstArray.Length; i++)
                txtblk_Result.Text += firstArray[i] + " ";

            // test whether reference was changed by FirstDouble
            if (firstArray == firstArrayCopy)
                txtblk_Result.Text += "\n\nThe references refer to the same array\n";
            else
                txtblk_Result.Text += "\n\nThe references refer to different arrays\n";

            // create and initialise a second array
            int[] secondArray = { 1, 2, 3 };

            // copy of secondArray reference(we take a copy so we can see if
            // the reference has changed after being passed to the called method
            int[] secondArrayCopy = secondArray;

            txtblk_Result.Text += "\n Test passing secondArray reference by reference";

            txtblk_Result.Text += "\n\n Contents of secondArray before calling secondDouble (doubles each element value):\n\t";

            // print contents of secondArray before calling method
            for (int i = 0; i < secondArray.Length; i++)
                txtblk_Result.Text += secondArray[i] + " ";

            // call secondDouble using ref to pass the original reference and not a copy
            SecondDouble(ref secondArray);

            txtblk_Result.Text += "\n\nContents of secondArray after calling SecondDouble:\n\t";

            // print contents of secondArray after calling method
            for (int i = 0; i < secondArray.Length; i++)
                txtblk_Result.Text += secondArray[i] + " ";

            // test whether reference was changed by SecondDouble
            if (secondArray == secondArrayCopy)
                txtblk_Result.Text += "\n\nThe references refer to the same array\n";
            else
                txtblk_Result.Text += "\n\nThe references refer to different arrays\n";

        }

        // modify elements of array AND attempt to modify reference
        // we have a copy of the reference so should not modify original reference
        void FirstDouble(int[] array)
        {
            // double each element's value
            for (int i = 0; i < array.Length; i++)
                array[i] *= 2;

            // create new reference and assign it to array
            array = new int[] { 11, 12, 13 };
        }

        // modify elements of array AND attempt to modify reference
        // we have access to the original reference so it will be modified
        void SecondDouble(ref int[] array)
        {
            // double each element's value
            for (int i = 0; i < array.Length; i++)
                array[i] *= 2;

            // create new reference and assign it to array
            array = new int[] { 11, 12, 13 };
        }
    }
}
