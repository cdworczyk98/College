using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    // CheckinAccount incurrs a fee for each transaction performed on the account
    // includes credit and debit transactions

    class CheckinAccount:Account
    {
        // private instance variable to hold the transaction fee
        private decimal fee;

        //public Property for the transaction fee (fee)
        public decimal Fee
        {

            get
            {
                return fee;

            }

            set
            {
                // checks that the value of the transaction fee is greater than 0
                // before assigning it to the fee instance variable
                if (value >= 0)
                    fee = value;
                else
                    throw new ArgumentOutOfRangeException("Fee", value, "Fee must be >= 0");


            }

        }

        // ChecinAccount constructor sets the transaction fee and calls the base class
        // (Account) to set the balance
        public CheckinAccount(decimal bal, decimal charge)
            : base(bal)
        {

            Fee = charge;
        }

        // calls the base class (Account) method to debit the account and if this
        // was successful then it debits the transaction fee.
        // The transaction fee is only debited if the debit transaction was successful
        public override bool Debit(decimal debitAmount)
        {
            if (base.Debit(debitAmount))
            {
                Balance = Balance - fee;
                return true;
            }
            else
                return false;
        }

        // class the base class (Account) credit method to credit the account, then
        // deducts the transaction fee for this action
        public override void Credit(decimal creditAmount)
        {
            base.Credit(creditAmount);
            Balance = Balance - fee;
        }

    }
}
