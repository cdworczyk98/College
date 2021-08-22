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

namespace PassArray
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
            int[] a = { 1, 2, 3, 4, 5 };
            txtblk_Result.Text = "Effects of passing entire array call by reference:\n\nThe values of the original array are:\n\t";

            for (int i = 0; i < a.Length; i++)
                txtblk_Result.Text += "     " + a[i];

            ModifyArray(a); // array is passed by reference

            txtblk_Result.Text += "\n\nThe values of the modified array are: \n\t";

            // display elements of array a
            for (int i = 0; i < a.Length; i++)
                txtblk_Result.Text += "     " + a[i];

            txtblk_Result.Text += "\n\nEffects of passing array element call-by-value:\n\n a[3] before ModifyElement: " + a[3];

            // array element passed call-by-value
            ModifyElement(a[3]);

            txtblk_Result.Text += "\n a[3] after ModifyElement: " + a[3];
        }

            // method modifies the array it receives, original value will be modified
            // pass-by-reference
            public void ModifyArray(int[] b)
            {
                for(int j=0; j<b.Length;j++)
                    b[j] *= 2;
            }

        // method modifies the integer passed to it, original will not be modified
        // pass-by-value
        public void ModifyElement(int e)
        {
            txtblk_Result.Text += "\nvalue received in ModifyElement: " + e;
            e *= 2;

            txtblk_Result.Text += "\n value calculated in ModifyElement: " + e;
        }
    }
}
