using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ArrayADTs
{
    class Program
    {
        static void Main(string[] args)
        {
            MyEx2Stack fixedFILO = new MyEx2Stack();
            Console.WriteLine("Chris");
            Console.WriteLine("Testing Ex2, the Fixed Stack");
            Console.WriteLine("Testing Stack is empty = " + fixedFILO.isEmpty());
            for (int i = 1; i < 11; i++)
            {
                fixedFILO.push(i);
            }
            Console.WriteLine("Number of  values in stack: " + fixedFILO.size());
            fixedFILO.display();
            //fixedFILO.push(666);
            Console.WriteLine("popping value" + fixedFILO.pop());
            Console.WriteLine("Last pushed value should have been popped");
            fixedFILO.display();
            Console.ReadLine();


        }
    }
}
