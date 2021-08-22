using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismStep1
{
    class CommissionEmployee : Object
    {

        private string firstName;
        private string lastName;
        private string socialSecurityNumber;
        private decimal grossSales;
        private decimal commissionRate;

        // 5 parameter constructor
        public CommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate)
        {

            firstName = first;
            lastName = last;
            socialSecurityNumber = ssn;
            GrossSales = sales;  // validate gross sales via property
            CommissionRate = rate;  // validate commission rate via property

        }

        // read-only property that gets first name
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        // read-only property that gets last name
        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        // read-only property that gets social security number
        public string SocialSecurityNumber
        {
            get
            {
                return socialSecurityNumber;
            }
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
        public virtual decimal Earnings()
        {
            return CommissionRate * GrossSales;
        }

        // return string representation of class
        public override string ToString()
        {
            return string.Format("{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}",
                "commission employee", FirstName, LastName, "social security number", SocialSecurityNumber,
                "gross sales", GrossSales, "commission rate", CommissionRate);

        }
    }
}
