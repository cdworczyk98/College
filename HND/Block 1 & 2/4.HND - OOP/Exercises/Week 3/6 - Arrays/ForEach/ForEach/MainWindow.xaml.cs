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

namespace ForEach
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
            int[,] gradeArray = { { 77, 68, 86, 73 }, 
                                { 98, 87, 89, 81 }, { 70, 90, 86, 81 } };
  	
   	      int lowGrade = 100;
  	
   	      foreach ( int grade in gradeArray )
   	      {
   	         if ( grade < lowGrade )
   	            lowGrade = grade;
   	      }
   	
   	      txtblk_Result.Text =  "The minimum grade is: " + lowGrade;

        }
    }
}
