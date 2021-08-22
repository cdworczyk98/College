using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismStep1
{
    class Program
    {
        static void Main(string[] args)
        {
            CommissionEmployee commissionEmployee = new CommissionEmployee("Sue", "Jones", "22-22-22", 10000.00M, 0.06M);
            BasePlusCommissionEmployee baseEmployee = new BasePlusCommissionEmployee("Bob", "Lewis", "33-33-33", 5000.00M, 0.04M, 300.00M);

            Console.WriteLine("{0} {1}: \n\n{2}\n{3}: {4:C}\n",
                "Call CommissionEmployee’s ToString and Earnings methods ", 
                "with base-class reference to base-class object", 
                commissionEmployee.ToString(),
                "earnings ", commissionEmployee.Earnings() );

            Console.WriteLine("{0} {1}: \n\n{2}\n{3}: {4:C}\n",
                "Call BasePlusCommissionEmployee’s ToString and Earnings methods ",
                "with derived-class reference to derived-class object",
                baseEmployee.ToString(),
                "earnings ", baseEmployee.Earnings());

            CommissionEmployee commissionEmployee2 = baseEmployee;

            Console.WriteLine("{0} {1}: \n\n{2}\n{3}: {4:C}\n",
                "Call BasePlusCommissionEmployee’s ToString and Earnings methods ", 
                "with base-class reference to derived-class object", 
                commissionEmployee2.ToString(),
                "earnings ", commissionEmployee2.Earnings() );

            Console.ReadKey();
        }
    }
}
