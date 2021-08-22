using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismStep1
{
    class BasePlusCommissionEmployee : CommissionEmployee
    {

        private decimal baseSalary;  //base salary per week

        // 6 parameter derived-class constructor
        // with call to base class CommissionEmployee constructor
        public BasePlusCommissionEmployee(string first, string last, string ssn, decimal sales,
            decimal rate, decimal salary)
            : base(first, last, ssn, sales, rate)
        {
            BaseSalary = salary;  // validate base salary via property
        }

        // property that gets and sets base salary
        public decimal BaseSalary
        {

            get
            {
                return baseSalary;
            }
            set
            {
                if (value >= 0)
                    baseSalary = value;
                else
                    throw new ArgumentOutOfRangeException("BaseSalary", value, "BaseSalary must be >=0");

            }
        }

        // calculate earnings
        public override decimal Earnings()
        {
            // not allowed - commissionRate and grossSales are private in base class
            return BaseSalary + base.Earnings();
        }

        // return string representation of BasePlusCommissionEmployee
        public override string ToString()
        {
            // not allowed as attempts to access private base class members
            return string.Format("base salaried {0}\n base salary: {1:C}",
                base.ToString(), BaseSalary);

        }
    }
}
