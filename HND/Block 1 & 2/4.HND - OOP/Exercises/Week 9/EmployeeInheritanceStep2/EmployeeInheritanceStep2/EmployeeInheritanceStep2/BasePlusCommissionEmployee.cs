using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeInheritanceStep2
{
    class BasePlusCommissionEmployee:CommissionEmployee 
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
                return baseSalary + (commissionRate * grossSales);
            }

            // return string representation of BasePlusCommissionEmployee
            public override string ToString()
            {
                // not allowed as attempts to access private base class members
                return string.Format("{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}\n{9}: {10:C}",
                "base salaried commission employee", firstName, lastName, "social security number", socialSecurityNumber,
                "gross sales", grossSales, "commission rate", commissionRate, "base salary", baseSalary);

            }

        }

 }
