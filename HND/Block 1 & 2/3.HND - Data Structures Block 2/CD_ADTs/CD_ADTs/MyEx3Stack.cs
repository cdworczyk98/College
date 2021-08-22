using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ADTs
{
    class MyEx3Stack : IStackADT
    {
        // **** Start of the class (MrTrumpStack) that implements the ADT using the LinkedList DS
        //declaration of a class which 'conforms to' the interface IStackADT

        private IntLinkedList DynamicStack; //Declares a Linked List structure of type IntLinkedList

        public MyEx3Stack()
        {
            //this constructor (which overrides the default constructor) creates a new stack of no fixed size
            DynamicStack = new IntLinkedList();
        }

        internal IntLinkedList IntLinkedList
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void push(int value)
        {
            //this method pushes value onto top of stack
            //required implementation of the method signature declared in interface StackADT
            DynamicStack.addLast(value); //instead of DynamicStack.addFirst(value);
        }

        public int pop()
        {
            //this method removes value from top of stack
            //required implementation of the method signature declared in interface StackADT
            return DynamicStack.removeLast(); //instead of DynamicStack.removeFirst(value);
        }

        public bool isEmpty()
        {
            //this method returns true if the stack is empty, otherwise false
            //required implementation of the method signature declared in interface StackADT
            return DynamicStack.isEmpty();
        }

        public int size()
        {
            //this method returns number of items in stack
            //required implementation of the method signature declared in interface StackADT
            return DynamicStack.size();
        }

        public void display()
        {
            //this method provides a console based display of stack contents
            //an additional method, not associated with the IStackADT interface
            DynamicStack.display();
        }
    }
}
