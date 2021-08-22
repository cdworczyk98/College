using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class MrTrumpStack
    {
        private IntLinkedList DynamicStack;

        public MrTrumpStack()
        {
            DynamicStack = new IntLinkedList();
        }

        internal IntLinkedList IntLinkedList
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            { }
        }

        public void push(int value)
        {
            DynamicStack.addLast(value);
        }

        public int pop()
        {
            return DynamicStack.removeLast();
        }

        public bool isEmpty()
        {
            return DynamicStack.isEmpty();
        }

        public int size()
        {
            return DynamicStack.size();
        }

        public void display()
        {
            DynamicStack.display();
        }
    }
}
