using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class IntLinkedList
    {
        class Node
        {
            public int value;
            public Node nextnode;

            public Node(int v)
            {
                value = v;
                nextnode = null;
            }

            public void add(int v)
            {
                if (nextnode == null) nextnode = new Node(v);
                else nextnode.add(v);
            }
        }

        private Node start;
        private int count;

        public IntLinkedList()
        {
            start = null;
            count = 0;
        }

        public void addLast(int value)
        {
            if (start == null) start = new Node(value);
            else start.add(value);
            count++;
        }

        public bool isEmpty()
        {
            return (count == 0);
        }

        public void addFirst(int value)
        {
            if (isEmpty()) addLast(value);
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
            int rvalue;
            if (isEmpty()) throw new Exception("The list is empty");
            else
            {
                rvalue = start.value;
                if(start.nextnode == null) start = null;
                else start = start.nextnode;
                count--;
            }
            return rvalue;
        }

        public int removeLast()
        {
            int rvalue;
            if (isEmpty()) throw new Exception("The list is empty");
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
            if (count == 0) Console.WriteLine("The list is empty");
            else
            {
                Console.WriteLine("The list has"+count+" items");
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
            return count;
        }
    }
}
