using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate BasePlusCommissionEmployee object
            Account account = new Account(2000M);

            Console.WriteLine("Account Balance: {0}", account.Balance);
            Console.WriteLine("Please input a withdraw amount: ");
            account.Debit(Convert.ToDecimal(Console.ReadLine()));
            Console.WriteLine(account.Balance);
            Console.ReadKey();
        }
    }
}
