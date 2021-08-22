using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nStack MENU(size -- 10)");
                Console.WriteLine("1. Add an element");
                Console.WriteLine("2. See the Top element.");
                Console.WriteLine("3. Remove top element.");
                Console.WriteLine("4. Display stack elements.");
                Console.WriteLine("5. Exit");
                Console.Write("Select your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter an Element : ");
                        st.Push(Console.ReadLine());
                        break;
                    case 2: Console.WriteLine("Top element is: {0}", st.Peek());
                        break;
                    case 3: Console.WriteLine("Element removed: {0}", st.Pop());
                        break;
                    case 4: st.Display();
                        break;
                    case 5: System.Environment.Exit(1);
                        break;
                }
                Console.ReadKey();
            }
        }

    }
}
