using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        interface StackADT
        {
            void push(int value);
            int pop();
            Boolean isEmpty();
            int size();
        }

        static void Main(string[] args)
        {
            MrTrumpStack dynamicFILO = new MrTrumpStack();
            Console.WriteLine("Chris\n");
            Console.WriteLine("Testing Dynamic ADT Stack Using LinkedList DS");
            Console.WriteLine("\nTesting stack is empty = " + dynamicFILO.isEmpty());
            for (int i = 0; i < 20; i++)
            {
                dynamicFILO.push(i);
            }
            Console.WriteLine("\nNumber of values in stack = " + dynamicFILO.size() + "\n");
            dynamicFILO.display();
            Console.ReadLine();
            dynamicFILO.push(20);
            dynamicFILO.display();
            Console.ReadLine();
            Console.WriteLine("popping bvalye" + dynamicFILO.pop() + "\n");
            Console.WriteLine("Last pushed value should have been popped");
            dynamicFILO.display();
            Console.ReadLine();
        }
    }
}
