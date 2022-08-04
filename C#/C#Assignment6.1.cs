using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateassignment1
{
    public delegate double ManagerSal(double salary);
    public delegate double Food(double FA);
    public delegate double Petrol(double PA);
    public delegate double Others(double OA);
    public delegate double Gross(double GS);
    public delegate double Pf(double PF);
    public delegate double Netsal(double NS);

    class @delegate
    {
        public double PA;
        public double FA;
        public double OA;
        public double salary;
        public double GS;
        public double NS;
        public double PF;
        public double TDS;
        public double ManagerSalary(double salary)
        {
            Console.WriteLine("manager salary" + salary);
            return salary;
        }
        public double FoodAllowances(double Salary)
        {
            FA = (Salary * 13) / 100;
            Console.WriteLine("Food allowances " + FA);
            return FA;

        }
        public double PetrolAllowances(double Salary)
        {
            PA = (Salary * 8) / 100;
            Console.WriteLine("petrol allowances " +PA);
            return PA;
        }
        public double OtherAllowances(double Salary)
        {
            OA = (Salary * 3) / 100;
            Console.WriteLine ("Other allowances " +OA);
            return OA;

        }
        public double GrossSalary(double Salary)
        {
            GS = Salary + FA + PA + OA;
            Console.WriteLine("Gross salary" +GS);
            return GS;

        }

        public double CalculateSalary()
        {
            PF = (GS * 10) / 100;
            Console.WriteLine("PF: " + PF);
            TDS = (GS * 18) / 100;
            Console.WriteLine("TDS: " + TDS);
            NS = GS - (PF + TDS);
            Console.WriteLine("NetSalary: " + NS);
            return NS;
        }
            public static void Main(string[] args)
            {
                @delegate d = new @delegate();
                d.FoodAllowances(25000);
                d.PetrolAllowances(25000);
                d.OtherAllowances(25000);
                d.GrossSalary(25000);
                d.CalculateSalary();

            }
        
    }
}
