using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInheritanceStep1
{
    public class CommissionEmployeeTest
    {
        public static void Main(string[] args)
        {

            // test for commission employee

            // instantiate CommissionEmployee object
            CommissionEmployee employee = new CommissionEmployee("Sue", "Jones", "22-22-22", 10000.00M, 0.06M);

            // display CommissionEmployee data
            Console.WriteLine("Employee information obtained by properties and methods: \n");

            Console.WriteLine("First name is {0}", employee.FirstName );
            Console.WriteLine("Last name is {0}", employee.LastName );
            Console.WriteLine("Social security number is {0}", employee.SocialSecurityNumber );
            Console.WriteLine("Gross sales are {0:C}", employee.GrossSales );
            Console.WriteLine("Commission rate is {0:F2}", employee.CommissionRate );
            Console.WriteLine("Earnings are {0:C}", employee.Earnings());

            employee.GrossSales = 5000.00M;
            employee.CommissionRate = 0.1M;

            Console.WriteLine("\n{0}:\n\n{1}",
                "Updated employee information obtained by ToString", employee);

            Console.WriteLine("earnings: {0:C}", employee.Earnings());

            Console.WriteLine("Press any key to continue and view the Base Plus Commission Employee");
            Console.ReadKey();

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
