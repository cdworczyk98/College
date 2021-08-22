using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyStep6
{
    class Program
    {
        static void Main(string[] args)
        {

            // create derived class objects

            SalariedEmployee salariedEmployee = new SalariedEmployee("John", "Smith", "111-11-1111", 800.00M);
            HourlyEmployee hourlyEmployee = new HourlyEmployee("Karen", "Price", "222-22-2222", 16.75M, 40.0M);
            CommissionEmployee commissionEmployee = new CommissionEmployee("Sue", "Jones", "333-33-3333", 10000.00M, 0.06M);
            BasePlusCommissionEmployee basePlusCommissionEmployee = new BasePlusCommissionEmployee("Bob", "Lewis", "444-44-4444", 5000.00M, 0.04M, 300.00M);
            PieceWorker pieceWorker = new PieceWorker("Chris", "Dworczyk", "555-555-5555", 100.00M, 10.00M);

            Console.WriteLine("Employees processed individually as their specific types: \n");

            // display each different employee's earnings for the month

            Console.WriteLine("{0}\n earned: {1:C}\n", salariedEmployee, salariedEmployee.Earnings());
            Console.WriteLine("{0}\n earned: {1:C}\n", hourlyEmployee, hourlyEmployee.Earnings());
            Console.WriteLine("{0}\n earned: {1:C}\n", commissionEmployee, commissionEmployee.Earnings());
            Console.WriteLine("{0}\n earned: {1:C}\n", basePlusCommissionEmployee, basePlusCommissionEmployee.Earnings());
            Console.WriteLine("{0}\n earned: {1:C}\n", pieceWorker, pieceWorker.Earnings());

            // now we are going to manipulate the objects polymorphically

            // create a 4 element Employee array
            // assigns employees an array of 4 Employee variables
            Employee[] employees = new Employee[5];

            // initialise the array with each of the 4 objects
            // we can assign the references of a derived class object to a base class variable
            // because of the "is a" relationship i.e. a salariedEmployee is a Employee
            employees[0] = salariedEmployee;
            employees[1] = hourlyEmployee;
            employees[2] = commissionEmployee;
            employees[3] = basePlusCommissionEmployee;
            employees[4] = pieceWorker;

            Console.WriteLine("Employees processed polymorphically");

            foreach(Employee currentEmployee in employees)
            {
                Console.WriteLine(currentEmployee); // invokes ToString in derived class

                // we need to determine if the elemement is a BasePlusCommissionEmployee 
                // as they are to be awarded an additional 10% of their base salary in this month's pay
                if (currentEmployee is BasePlusCommissionEmployee)
                {
                    // we need to add a 10% increase to the BaseSalary variable, but this variable only
                    // exists in the derived class and we are currently treating the object as the base class (Employee)
                    // downcast Employee reference to BasePlusCommissionEmployee reference so we cn access the derived class
                    // instance variable
                    BasePlusCommissionEmployee employee = (BasePlusCommissionEmployee)currentEmployee;
                    employee.BaseSalary *= 1.10M;
                    Console.WriteLine("new base salary with 10% increase is: {0:C}", employee.BaseSalary);
                }

                Console.WriteLine("earned {0:C} \n", currentEmployee.Earnings());
            } // end foreach

            // ADDITIONAL ACTIVITY
            // Every object knows its own type and can access this information through getType (inherited from System.Object)
            // GetType returns an object of class Type, which contains info. such as class name, method names, name of base class
            for (int j = 0; j < employees.Length; j++)
            {

                Console.WriteLine("Employee {0} is a {1} ", j, employees[j].GetType());
            }


            Console.ReadKey();

        }
    }
}
