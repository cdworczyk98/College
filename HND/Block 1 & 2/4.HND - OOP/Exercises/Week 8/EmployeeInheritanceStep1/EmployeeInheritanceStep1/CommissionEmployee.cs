using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInheritanceStep1
{
    public class CommissionEmployee:object  // inherits from System.object implicity, don't have to explicitly declare
    {
        private decimal grossSales;
        private decimal commissionRate;

        // auto-implemented properties
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }

        // 5 parameter constructor
        public CommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate)
        {

            FirstName = first;
            LastName = last;
            SocialSecurityNumber = ssn;
            GrossSales = sales;  // validate gross sales via property
            CommissionRate = rate;  // validate commission rate via property

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


        // calculate earnings
        public decimal Earnings()
        {
            return commissionRate * grossSales;
        }

        // return string representation of class
        public override string ToString()
        {
            return string.Format("{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}", 
                "commission employee", FirstName, LastName, "social security number", SocialSecurityNumber,
                "gross sales", GrossSales, "commission rate", commissionRate);

        }

    }
}
