using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SavingsAccount:Account
    {
        private decimal intrestRate;

        public SavingsAccount(decimal bal, decimal rate):base(bal)
        {
            IntrestRate = rate;
        }

        public decimal IntrestRate
        {
            get { return intrestRate; }
            set { intrestRate = value; }
        }

        public decimal CalculateIntrest()
        {
            return intrestRate * Balance;
        }
    }
}
