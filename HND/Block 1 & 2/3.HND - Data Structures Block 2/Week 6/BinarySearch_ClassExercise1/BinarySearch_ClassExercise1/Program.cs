using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace RecursiveBinarySearch
{
    class Program
    {
        // @ Roe, January 2018

        static int getNumber()
        {
            int value;
            Console.WriteLine("Start by entering the number you wish to find");
            value = int.Parse(Console.ReadLine());
            return value;
        }

        static void Main(string[] args)
        {
            int numberOfElements = 20;
            //int[] DataSet = new int [numberOfElements];
            int[] DataSet = { 3, 7, 13, 17, 18, 23, 27, 34, 42, 46, 51, 59, 63, 69, 74, 175, 255, 450, 690, 1000 };

            int left = 0;
            int right = numberOfElements - 1;
            bool found = false;
            int pos;
            int id;

            id = getNumber();

            for (int index = 0; index < numberOfElements; index++)
            //foreach (int index in DataSet)
            {
                Console.Write(DataSet[index] + " ");
            }
            Console.ReadLine();

            while (left <= right)
            {
                pos = (left + right) / 2;

                if (DataSet[pos] == id)
                {
                    found = true;
                    Console.WriteLine("{0} - {1} found at index {2}", found, id, pos);
                    Console.ReadLine();
                }

                if (DataSet[pos] < id)
                {
                    left = pos + 1; // so search to the right
                }
                else
                {
                    right = pos - 1; // so search to the left
                }
            } // end of while loop
            if (found == false)
            {
                Console.WriteLine("Number not in sorted list");
                Console.ReadLine();
            }
        }
    }
}

