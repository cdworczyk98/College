using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ArrayADTs
{
    class IntArrayList
    {
        private int[] values; //array used to store integer values
        private int count; //used to show number of values held in the array

        public IntArrayList(int capacity)
        {
            //creates an array data structure with a maximum size set to capacity
            values = new int[capacity];
            count = 0;
        }

        public bool isEmpty()
        {
            //this method tests if the array data structure is empty
            //it returns true if empty, otherwise false
            return (count == 0);
        }

        public bool isFull()
        {
            //this method tests if the array's capacity is reached
            //returns true if full, otherwise false
            return values.Length == count;
        }

        public void addFirst(int value)
        {
            //adds an integer value to start of the array data structure
            //throwing an Exception if full
            if (isFull())
            {
                throw new Exception("the Data Structure is full");
                // n.b. this exception is not handled
            }
            if (isEmpty())
            {
                addLast(value);
            }
            else
            {
                for (int pos = count; pos > 0; pos--)
                {
                    values[pos] = values[pos - 1];
                }
                values[0] = value;
                count++;
            }
        }

        public void addLast(int value)
        {
            //adds value to end of the array data structure
            //throws exception if full
            if (isFull())
            {
                throw new Exception("Data Structure full");
                // n.b. this exception is not handled
            }
            values[count++] = value;
        }

        public int removeLast()
        {
            //removes and returns last value in the array data structure
            //throws exception if empty
            if (isEmpty())
            {
                throw new Exception("Data Structure empty");
                // n.b. this exception is not handled
            }
            return values[--count];
        }

        public int size()
        {
            //returns the number of items in the array data structure
            return count;
        }

        public void display()
        {
            //used for testing -
            //a console-based UI showing the contents of the array data structure
            if (count == 0)
                Console.WriteLine("Data Structure is empty");
            else
            {
                Console.WriteLine("Data Structure has " + count + " items");
                for (int i = 0; i < count; i++)
                    Console.WriteLine("value: " + values[i]);
            }
        }
    }

}
