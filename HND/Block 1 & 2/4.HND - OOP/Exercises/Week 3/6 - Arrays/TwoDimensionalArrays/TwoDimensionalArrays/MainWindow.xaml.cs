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

namespace TwoDimensionalArrays
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
            // declaration and initialisation of rectangular arrray
            int[,] array1 = new int[,]{{1,2,3}, {4,5,6}};

            // declaration and initialisation of a jagged array
            int[][] array2 = new int[3][];
            array2[0] = new int[] { 1, 2 };
            array2[1] = new int[] { 3 };
            array2[2] = new int[] { 4, 5, 6 };

            txtblk_Result.Text = "Values in array1 by row are: \n";

            // output values in array1
            for ( int i = 0; i < array1.GetLength( 0 ); i++ )
  	        {
   	            for ( int j = 0; j < array1.GetLength( 1 ); j++ ) 
   	                txtblk_Result.Text += array1[ i, j ] + "  ";
   	
   	            txtblk_Result.Text += "\n";
   	        }


            txtblk_Result.Text += "\nValues in array2 by row are\n";
   	   
   	        // output values in array2
   	        for ( int i = 0; i < array2.Length; i++ )
  	        {
   	            for ( int j = 0; j < array2[ i ].Length; j++ )
   	                txtblk_Result.Text += array2[ i ][ j ] + "  ";
   	
   	            txtblk_Result.Text += "\n";
   	        }

        }
    }
}
