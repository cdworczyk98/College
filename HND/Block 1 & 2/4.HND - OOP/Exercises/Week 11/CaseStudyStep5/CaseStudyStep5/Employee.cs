using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyStep5
{
    public abstract class Employee
    {
        // read only property that gets employee's first name
        public string FirstName { get; private set; }

        // read only property that gets employee's last name
        public string LastName { get; private set; }

        // read only property that gets employees social security number
        public string SocialSecurityNumber { get; private set; }

        // 3 parameter constructor
        public Employee(string first, string last, string ssn)
        {
            FirstName = first;

            LastName = last;

            SocialSecurityNumber = ssn;

        }

        // abstract method overridden by derived class
        // we cannot calculate the earnings for a general employee, we need to know
        // what type of employee before we can calculate the earnings
        public abstract decimal Earnings(); // no implementation here

        // return string representation of Employee object, using properties
        public override string ToString()
        {
            return string.Format("{0} {1}\n social security number: {2}", FirstName, LastName, SocialSecurityNumber);
        }

    }
}
