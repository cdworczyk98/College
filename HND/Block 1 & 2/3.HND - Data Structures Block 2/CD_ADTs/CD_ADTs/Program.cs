using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ADTs
{
    class Program
    {
        static void Main(string[] args)
        {

            MyEx3Stack dynamicFILO = new MyEx3Stack();
            Console.WriteLine("Chris\n");
            Console.WriteLine("Testing Ex3, the Dynamic Stack");
            Console.WriteLine("\nTesting stack is empty = " + dynamicFILO.isEmpty());
            for (int i = 1; i < 15; i++)
            {
                dynamicFILO.push(i);
            }
            Console.WriteLine("\nNumber of values in stack = " + dynamicFILO.size() + "\n");
            dynamicFILO.display();
            Console.ReadLine();
            dynamicFILO.push(666);
            dynamicFILO.display();
            Console.ReadLine();
            Console.WriteLine("popping value " + dynamicFILO.pop() + "\n");
            Console.WriteLine("Last pushed value should have been popped");
            dynamicFILO.display();
            Console.ReadLine();

        }
    }
}
