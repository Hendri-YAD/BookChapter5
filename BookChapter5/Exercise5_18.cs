using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookChapter5
{
    class Exercise5_18
    {
        public static void Main()
        {
            int accountNumber = 0;
            double initBalance, totalCharged, totalCredit, creditLimit;

            while(accountNumber != -1)
            {
                Console.Write("Please enter the account number or -1 to quit: ");
                accountNumber = Convert.ToInt32(Console.ReadLine());

                if (accountNumber == -1)
                    break;

                Console.Write("Please enter the initial balance: ");
                initBalance = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter the total items charged this month: ");
                totalCharged = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter the total credits applied this month: ");
                totalCredit = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter the credit limit: ");
                creditLimit = Convert.ToDouble(Console.ReadLine());

                Customer a = new Customer(accountNumber, initBalance, totalCharged, totalCredit, creditLimit);

                if (a.CreditLimitExceeded())
                    Console.WriteLine("Credit limit exceeded");                
            }            
        }

        class Customer
        {
            int accountNumber;
            double initBalance, totalCharged, totalCredit, creditLimit;

            public Customer(int accountNumber, double initBalance, double totalCharged, double totalCredit, double creditLimit)
            {
                this.accountNumber = accountNumber;
                this.initBalance = initBalance;
                this.totalCharged = totalCharged;
                this.totalCredit = totalCredit;
                this.creditLimit = creditLimit;
            }            

            public double NewBalance
            {
                get { return initBalance + totalCharged - totalCredit; }
            }

            public bool CreditLimitExceeded()
            {
                return NewBalance > creditLimit;
            }

        }
    }
}
