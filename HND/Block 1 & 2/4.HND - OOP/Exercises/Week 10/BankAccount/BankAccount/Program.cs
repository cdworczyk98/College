using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is your client application that it making use of the services
            // provided by the classes

            // START OF Account class TESTING

            // instanitate (create) a new Account object
            Account wlcAccount = new Account(500.00M);

            // test the ability to debit from the account
            Console.WriteLine("Your starting account balance is {0:C}", wlcAccount.Balance);
            Console.WriteLine("Please enter the amount you wish to debit");
            decimal debitAmount = Convert.ToDecimal(Console.ReadLine());
            wlcAccount.Debit(debitAmount);
            Console.WriteLine("Your current balance is {0:C}", wlcAccount.Balance);

            // test the ability to credit money to the account
            Console.WriteLine("Please enter the amount you wish to credit to your account");
            decimal creditAmount = Convert.ToDecimal(Console.ReadLine());
            wlcAccount.Credit(creditAmount);
            Console.WriteLine("Your current balance is {0:C}\n\n", wlcAccount.Balance);

            Console.WriteLine("*****************************************************");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            // END OF Account class TESTING

            // START OF SavingsAccount class TESTING

            // instanitate (create) a new SavingsAccount object
            SavingsAccount savingAccount = new SavingsAccount(600.00M, 0.5M);

            // savingAccount inherits credit and debit methods from Account class
            // test the ability to debit from the account
            Console.WriteLine("\n\nYour starting savings account balance is {0:C} and the interest rate is {1}", savingAccount.Balance, savingAccount.InterestRate);
            Console.WriteLine("Please enter the amount you wish to debit your savings account");
            decimal debitAmount2 = Convert.ToDecimal(Console.ReadLine());
            savingAccount.Debit(debitAmount2);
            Console.WriteLine("Your current saving account balance is {0:C}", savingAccount.Balance);

            // test the ability to credit money to the account
            Console.WriteLine("Please enter the amount you wish to credit to your savings account");
            decimal creditAmount2 = Convert.ToDecimal(Console.ReadLine());
            savingAccount.Credit(creditAmount2);
            Console.WriteLine("Your current saving account balance is {0:C}\n", savingAccount.Balance);

            // calculate the interest earned on this balance, then credit this to the account
            decimal totalInterest = savingAccount.CalculateInterest();
            savingAccount.Credit(totalInterest);
            Console.WriteLine("Your current saving account interest is {0:C}\n", totalInterest);
            Console.WriteLine("Your current saving account balance plus interest is {0:C}\n", savingAccount.Balance);

            Console.WriteLine("*****************************************************");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            // END OF SavingsAccount class TESTING

            // START OF CheckinAccount class TESTING

            // instanitate (create) a new CheckinAccount object
            CheckinAccount checkinAccount = new CheckinAccount(600.00M, 1.50M);

            // CheckinAccount overrides credit and debit methods from Account class in order to deduct 
            // a transaction fee
            // test the ability to debit from the account
            Console.WriteLine("\n\nYour starting checkin account balance is {0:C} and the transaction charge is {1:C}", checkinAccount.Balance, checkinAccount.Fee);
            Console.WriteLine("Please enter the amount you wish to debit your checkin account");
            decimal debitAmount3 = Convert.ToDecimal(Console.ReadLine());
            checkinAccount.Debit(debitAmount3);
            Console.WriteLine("Your current checkin account balance is {0:C}", checkinAccount.Balance);

            // test the ability to credit money to the account
            Console.WriteLine("Please enter the amount you wish to credit to your checkin account");
            decimal creditAmount3 = Convert.ToDecimal(Console.ReadLine());
            checkinAccount.Credit(creditAmount3);
            Console.WriteLine("Your current checkin account balance is {0:C}\n", checkinAccount.Balance);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
