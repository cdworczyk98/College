using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4StudentHashtable
{
    static class Program
    {
        /* 
        HND Computing: Software Development (2o15/2o16)
         
        Software Development: DataStructures (H16Y 35)
        Outcomes 2(part2),3 & 4, Exercise 4
          
        A practical assessment - making use of C#'s Hashtable Collection Class
        */

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
