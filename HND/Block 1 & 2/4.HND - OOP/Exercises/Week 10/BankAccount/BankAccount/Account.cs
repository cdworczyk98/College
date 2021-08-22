using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        //instance variable to store the account balance
        private decimal balance;

        // public Property for private instance variable balance
        public decimal Balance
        {

            get
            {
                return balance;

            }

            set
            {
                // checks that the balance is greater than 0 before assigning it to the 
                // instance variable
                if (value >= 0)
                    balance = value;
                else
                    throw new ArgumentOutOfRangeException("Balance", value, "Balance must be >= 0");


            }


        }

        // Account class constructor
        public Account(decimal amount)
        {

            Balance = amount; // validate balance via property

        }

        // add creditAmount to current balance in order to credit the account
        public virtual void Credit(decimal creditAmount)
        {
            Balance = Balance + creditAmount;
        }

        // debit money from the account
        // returns true if money was successfully debited, otherwise false
        public virtual bool Debit(decimal debitAmount)
        {
            if (debitAmount < Balance)
            {
                Balance = Balance - debitAmount;
                return true;
            }
            else
            {
                Console.Write("Withdrawal amount £{0} exceeded balance £{1}\n\n",
                    debitAmount, Balance);
                return false;
            }
        }
    }
}
