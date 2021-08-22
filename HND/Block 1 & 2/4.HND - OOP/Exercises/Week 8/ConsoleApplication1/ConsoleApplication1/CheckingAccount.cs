using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CheckingAccount:Account
    {
        private decimal fee;

        public CheckingAccount(decimal bal, decimal fee):base(bal)
        {
            Fee = fee;
        }

        public decimal Fee
        {
            get { return fee; }
            set { fee = value; }
        }

        public override void Credit(decimal amount)
        {
            if (Balance > Fee)
            {
                Balance += amount - Fee;
            }
        }

        public override bool Debit(decimal amount)
        {
            if (Balance > (amount + Fee))
            {
                Balance -= amount + Fee;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
