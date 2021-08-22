using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInheritanceStep1
{
    public class BasePlusCommissionEmployee
    {
        private decimal grossSales;
        private decimal commissionRate;
        private decimal baseSalary;

        // auto-implemented properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }

        // 6 parameter constructor
        public BasePlusCommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate, decimal salary)
        {
            // implicit call to object constructor occurs here

            FirstName = first;
            LastName = last;
            SocialSecurityNumber = ssn;
            GrossSales = sales; // validate gross sales via property
            CommissionRate = rate; // validate commission rate via property
            BaseSalary = salary;  // validate base salary via property
        }

        
        // property that gets and sets gross sales
        public decimal GrossSales
        {
            get
            {
                return grossSales;
            }
            set
            {

                if (value >= 0)
                    grossSales = value;
                else
                    throw new ArgumentOutOfRangeException("Gross Sales", value, "Gross sales must be >= 0");

            }
        }

        // property that gets and sets commission rate
        public decimal CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {

                if (value > 0 && value < 1)
                    commissionRate = value;
                else
                    throw new ArgumentOutOfRangeException("Commission Rate must be > 0 and < 1");

            }
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

                if (value > 0 )
                    baseSalary = value;
                else
                    throw new ArgumentOutOfRangeException("Base salary must be > 0 ");

            }
        }

        // calculate earnings
        public decimal Earnings()
        {
            return baseSalary + (commissionRate * grossSales);
        }

        // return string representation of class
        public override string ToString()
        {
            return string.Format("{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}\n{9}: {10:C}",
                "base salaried commission employee", FirstName, LastName, "social security number", SocialSecurityNumber,
                "gross sales", GrossSales, "commission rate", commissionRate, "base salary", baseSalary);

        }

    }
}
