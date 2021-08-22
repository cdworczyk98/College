using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{

    // SavingsAccount allows customers to earn interest on their savings
    class SavingsAccount:Account
    {
        // private instance variable interestRate
        private decimal interestRate;

        // public Property for private instance variable interestRate
        public decimal InterestRate
        {

            get
            {
                return interestRate;

            }

            set
            {
                // checks to see that the interest rate is greater than 0 
                // before assigning it to the interestRate variable
                if (value >= 0)
                    interestRate = value;
                else
                    throw new ArgumentOutOfRangeException("Interest Rate", value, "Interest rate must be >= 0");


            }


        }

        // SavingsAccount constructor - sets the interestRate and calls the base class
        // (Account) to set the balance
        public SavingsAccount(decimal bal, decimal rate)
            : base(bal)
        {
            interestRate = rate;
        }

        // calculates the interest earned on the current balance
        public decimal CalculateInterest()
        {

            return interestRate * Balance;

        }


    }
}
