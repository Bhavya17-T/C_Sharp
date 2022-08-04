using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateassignment2
{
    class bank
    {
        public static double Atm_Pin { get; private set; }

        public delegate void Bank(int x);

        public class Account
        {
            public double AccountNumber { get; set; }
            public string CustomerName { get; set; }
            public decimal bank_balance = 13434; 
            public event Bank UnderBalance;
            public event Bank ZeroBalance;

            public void Insufficient(int i)
            {
                UnderBalance(i);
            }

            public void DepositAmount(int d)
            {
                ZeroBalance(d);
            }
            public void withdraw(int i)
            {
                if (i < bank_balance && bank_balance != 0)
                {
                    Console.WriteLine("please take your money");
                    Console.WriteLine("Transaction Successfull");
                    Console.WriteLine("Available Balance is:" + (bank_balance - i));
                }
                else if (i > bank_balance && bank_balance != 0)
                {
                    Console.WriteLine("Insufficient Amount");
                    Console.WriteLine("Your Current Balance is:" + bank_balance + "only");
                }
                else
                {
                    Console.WriteLine("Zero Balance:" + bank_balance);
                }
            }
            public void deposit(int i)
            {
                Console.WriteLine("Balance after depositing:" + (bank_balance + i));
            }
        }

        static void Main(string[] args)
        {
            Account A = new Account();
            Console.WriteLine("Hello Customer!");
            Console.WriteLine("Enter Your Pin Number ");
            Atm_Pin = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("*Welcome to ATM Service*\n");
            Console.WriteLine("1. Withdraw");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("select your option: 1 or 2 ");
            string withdraw = Console.ReadLine();
            if (withdraw == "1")
            {
                Console.WriteLine("Enter your amount to be Withdraw");
                int withdrawbalance = int.Parse(Console.ReadLine());
                A.UnderBalance += new Bank(A.withdraw);
                A.Insufficient(withdrawbalance);
            }
            else
            {
                Console.WriteLine("Enter your amount to be Deposit:");
                int depositbalance = int.Parse(Console.ReadLine());
                A.ZeroBalance += new Bank(A.deposit);
                A.deposit(depositbalance);
            }
            
        }
    }
}

