using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeInheritanceStep3
{
    class Program
    {
        static void Main(string[] args)
        {
           

            // test for base plus commission employee

            // instantiate BasePlusCommissionEmployee object
            BasePlusCommissionEmployee baseEmployee = new BasePlusCommissionEmployee("Bob", "Lewis", "33-33-33", 5000.00M, 0.04M, 300.00M);

            Console.WriteLine("Base Plus Commission Employee information obtained by properties and methods: \n");

            Console.WriteLine("First name is {0}", baseEmployee.FirstName);
            Console.WriteLine("Last name is {0}", baseEmployee.LastName);
            Console.WriteLine("Social security number is {0}", baseEmployee.SocialSecurityNumber);
            Console.WriteLine("Gross sales are {0:C}", baseEmployee.GrossSales);
            Console.WriteLine("Commission rate is {0:F2}", baseEmployee.CommissionRate);
            Console.WriteLine("Base salary is {0:C}", baseEmployee.BaseSalary);
            Console.WriteLine("Earnings are {0:C}", baseEmployee.Earnings());

            baseEmployee.BaseSalary = 1000.00M;

            Console.WriteLine("\n{0}:\n\n{1}",
                "Updated employee information obtained by ToString", baseEmployee);

            Console.WriteLine("earnings: {0:C}", baseEmployee.Earnings());
            Console.ReadKey();
        }
    }
}
