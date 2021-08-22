using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        // @ Roe, January 2018

        static void Main(string[] args)
        {
            int sizeOfArray = 6;
            string[] ArrayToSort = { "Heather","Craig","Christopher","David","Tony","Robbie" };
            bool swapMade = true;
            int numOfComparisons;
            int pass = 0;

            numOfComparisons = sizeOfArray - 1;

            for (int index = 0; index < sizeOfArray; index++) // try foreach()
            {
                Console.Write(ArrayToSort[index] + " ");
            }
            Console.ReadLine();

            while (swapMade)
            {
                swapMade = false;
                int swapsMade = 0;

                for (int index = 0; index < numOfComparisons; index++) // try foreach()
                {
                    if (string.Compare(ArrayToSort[index], ArrayToSort[index + 1]) > 0)
                    { 
                        // swap elements
                        string temp;
                        temp = ArrayToSort[index];
                        ArrayToSort[index] = ArrayToSort[index + 1];
                        ArrayToSort[index + 1] = temp;
                        swapMade = true;
                        swapsMade++;
                    }
                }
                numOfComparisons--;
                pass++;

                Console.WriteLine("\nAfter pass {0}", pass);
                for (int index = 0; index < sizeOfArray; index++)
                {
                    Console.Write(ArrayToSort[index] + " ");
                }
                Console.WriteLine("\nNumber of comparisons made = {0}", numOfComparisons + 1);
                Console.WriteLine("and Number of swaps made = " + swapsMade);
                Console.ReadLine();

                if (swapsMade == 0)
                {
                    Console.WriteLine("Data sorted into ascending order, please press return to exit");
                    Console.ReadLine();
                }

            }
        }
    }
}
