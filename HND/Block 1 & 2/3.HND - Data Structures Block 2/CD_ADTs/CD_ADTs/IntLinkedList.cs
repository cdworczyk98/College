using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ADTs
{
    class IntLinkedList
    {
        class Node
        {
            //(inner) Node class - only available to this IntLinkedList class
          
            public int value; //the value stored in the node
            public Node nextnode; //a link to the next node in list

            public Node(int v) //creates an initial node with value v
            {
                value = v;
                nextnode = null;
            }
                        
            public void add(int v)
            {
                //recursive (self-referential) add - adds a new node with value v to the list
                if (nextnode == null)
                    nextnode = new Node(v);
                else
                    nextnode.add(v);
            }
        } //end of Node class


        private Node start; //private instance variable declaring node at start of the list
        private int count; //private instance variable declaring number of nodes in the list
        
        public IntLinkedList()
        {
            //constructor to create a new empty linked list
            start = null;
            count = 0;
        }
                
        public void addLast(int value)
        {
            //adds a value to the end of the list
            if (start == null)
            {
                start = new Node(value);
            }
            else
            {
                start.add(value);
            }
            count++;
        }
        
        public bool isEmpty()
        {
            //this method returns true if the list is empty, otherwise false
            return (count == 0);
        }

        public void addFirst(int value)
        {
            //adds a value to the start of the list
            if (isEmpty())
            {
                addLast(value);
            }
            else
            {
                Node temp = start;
                start = new Node(value);
                start.nextnode = temp;
                count++;
            }
        }

        public int removeFirst()
        {
            //removes and returns the first value in the list
            //throws an exception however, should the list be empty
            int rvalue;
            if (isEmpty())
            {
                throw new Exception("list is empty");
            }
            else
            {
                rvalue = start.value;
                if (start.nextnode == null)
                    start = null;
                else
                    start = start.nextnode;
                count--;
            }
            return rvalue;
        }

        public int removeLast()
        {
            //removes and returns the last value in the list
            //throws an exception however, should the list be empty
            int rvalue;
            if (isEmpty())
            {
                throw new Exception("list is empty");
            }
            else
            {
                if (count == 1)
                {
                    rvalue = start.value;
                    start = null;
                }
                else
                {
                    Node temp = start.nextnode;
                    Node prev = start;
                    while (temp.nextnode != null)
                    {
                        prev = temp;
                        temp = temp.nextnode;
                    }
                    rvalue = temp.value;
                    prev.nextnode = null;
                }
                count--;
            }
            return rvalue;
        }

        public void display()
        {
            //used for testing -
            //a console-based UI showing the contents of the list
            if (count == 0)
                Console.WriteLine("The list is empty");
            else
            {
                Console.WriteLine("The list has " + count + " items");
                Node curnode = start;
                while (curnode != null)
                {
                    Console.WriteLine("Value: " + curnode.value);
                    curnode = curnode.nextnode;
                }
            }
        }

        public int size()
        {
            //returns the number of items in the list
            return count;
        }
    } //end of IntLinkedList class
}
