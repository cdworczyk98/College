using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Account
    {
        private decimal balance;

        public Account(decimal bal)
        {
            Balance = bal;
        }

        public decimal Balance
        {
            get { return balance; }

            set 
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Account balance", value, "You can't have less than 0 money in account.");
                else
                    balance = value;
            }
        }

        public virtual void Credit(decimal amount)
        {
            Balance += amount;
        }

        public virtual bool Debit(decimal amount)
        {
            if (Balance > amount)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                Console.WriteLine("Debit amount ecxeeded account balance.");
                return false;
            }
        }

    }
}
