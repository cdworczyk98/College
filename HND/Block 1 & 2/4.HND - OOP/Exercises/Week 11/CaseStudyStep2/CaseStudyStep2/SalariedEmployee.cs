using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyStep2
{
    public class SalariedEmployee:Employee
    {
        private decimal weeklySalary;

        // Property that gets and sets salaried employee's salary
        public decimal WeeklySalary
        {
            get
            {
                return weeklySalary;
            }

            set
            {
                if (value >= 0) // validation
                    weeklySalary = value;
                else
                    throw new ArgumentOutOfRangeException("WeeklySalary", value, "WeeklySalary must be >= 0");
            }
        }

        // 4 parameter constructor
        public SalariedEmployee(string first, string last, string ssn, decimal salary) : base(first, last, ssn)
        {
            WeeklySalary = salary;
        }

        // calculate earnings.  Override abstract methiod Earnings in Employee
        public override decimal Earnings()
        {
            return WeeklySalary;

        }

        // return string representation of SalariedEmployee object
        public override string ToString()
        {
            return string.Format("salaried employee: {0}\n{1}: {2:C}", base.ToString(), "weekly salary", WeeklySalary);
        }
    }
}
