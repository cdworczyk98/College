using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyStep5
{
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        private decimal baseSalary;  // base salary per week

        // Property that gets and sets baseSalary
        public decimal BaseSalary
        {
            get
            {
                return baseSalary;
            }

            set
            {
                if (value > 0)
                    baseSalary = value;
                else
                    throw new ArgumentOutOfRangeException("BaseSalary", value, "BaseSalary must be >=0");

            }
        }

        // 6 parameter constructor
        public BasePlusCommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate, decimal salary)
            : base(first, last, ssn, sales, rate)
        {
            BaseSalary = salary;

        }

        // calculate earnings.  Override CommissionEmployee Earnings
        public override decimal Earnings()
        {
            return BaseSalary + base.Earnings();

        }

        // return string representation of BasePlusCommissionEmployee object
        public override string ToString()
        {
            return string.Format("base-salaried {0}; base salary: {1:C}", base.ToString(), BaseSalary);
        }
    }
}
