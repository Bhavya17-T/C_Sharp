using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateassign
{
    public delegate void Notify1();
    class ICICIBank
    {
        protected double AccountNumber;
        protected string CustomerName;
        protected double Balance;
        protected double Amount;
        public event Notify1 ZeroBalance;
        public event Notify1 UnderBalance;
        public void Diposit()
        {
            Console.WriteLine("Welcome to ICICI Services");
            Console.WriteLine("enter account number");
            AccountNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("enter customer name");
            CustomerName = Console.ReadLine();
            Console.WriteLine("enter amount to disposit");
            Balance = double.Parse(Console.ReadLine());
            Console.WriteLine("balance amount is" + ":" + Balance);
        }
        public virtual void WithDraw1()
        {

            Console.WriteLine("enter amount to withdrawl");
            Amount = int.Parse(Console.ReadLine());

            if (Balance == 0)
            {
                OnZeroBalance();
            }

            else if (Amount > Balance)
            {
                Onunderbalance();
            }
            else
            {
               
                Console.WriteLine("your balance is" + ":" + (Balance-Amount) + ";" + "ICICITRANSACTION SUCCESSFULL");

            }

        }
        protected virtual void OnZeroBalance()
        {
            ZeroBalance?.Invoke();
        }
        protected virtual void Onunderbalance()
        {
            UnderBalance?.Invoke();
        }

    }

    class ICICI
    {
        public static void Main()
        {
            ICICIBank account = new ICICIBank();
            account.Diposit();
            account.WithDraw1();
            account.ZeroBalance += z1_ZeroBalance;
            account.UnderBalance += z2_underbalace;
        }

        public static void z1_ZeroBalance()
        {
            Console.WriteLine("Transaction cannot be continued as balance is zero in Account ");
        }
        public static void z2_underbalace()
        {
            Console.WriteLine("Transaction cannot be continued as balance is insufficient");

        }
    }
}

