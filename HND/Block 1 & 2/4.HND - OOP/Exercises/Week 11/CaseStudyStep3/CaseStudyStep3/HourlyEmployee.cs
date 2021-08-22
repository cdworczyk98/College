using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyStep3
{
    public class HourlyEmployee:Employee
    {

        private decimal wage; // wage per hour
        private decimal hours; // hours worked for the week

        // Property that gets and sets employees wage
        public decimal Wage
        {
            get
            {
                return wage;
            }

            set{
                if(value >= 0) //validation
                    wage = value;
                else
                    throw new ArgumentOutOfRangeException("Wage", value, "Wage must be >= 0");
            }

        }

        // Property that gets and sets employees hours
        public decimal Hours
        {
            get
            {
                return hours;
            }

            set
            {
                if (value >= 0 && value <= 168) //validation
                    hours = value;
                else
                    throw new ArgumentOutOfRangeException("Hours", value, "Hours must be >= 0 and <= 168");
            }

        }

        // 5 parameter constructor
        public HourlyEmployee(string first, string last, string ssn, decimal hourlyWage, decimal hoursWorked) : base (first, last, ssn)
        {
            Wage = hourlyWage;
            Hours = hoursWorked;
        }

        public override decimal Earnings()
        {
            if (Hours <= 40) // no overtime
                return Wage * Hours;
            else
                return (40 * Wage) + ((Hours - 40) * Wage * 1.5M);
        }

        // return string representation of HourlyEmployee object
        public override string ToString()
        {
            return string.Format("hourly employee: {0}\n{1}: {2:C}; {3}: {4:F2}", base.ToString(), "hourly wage", Wage, "hours worked", Hours);
        }
    }
}
