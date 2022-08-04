using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManagement
{
    
     class Program
     {
        public void method()
        {
            List<string> DeptName = new List<string>();
            DeptName.Add("HR");
            DeptName.Add("Marketing");
            DeptName.Add("Finance");
            DeptName.Add("Sales");
            if (DeptName.Contains("HR"))
            {
                Console.WriteLine("enter employee number");
                int EmpNo = int.Parse(Console.ReadLine());
                Console.WriteLine("enter emp name");
                string empname = Console.ReadLine();
                Console.WriteLine("enter emp salary");
                double Salary = double.Parse(Console.ReadLine());

            }         
        }
        static void Main(string[] args)
        {
            int EmpNo;
            string EmpName;
            double Salary, HRA, TA, DA, PF, TDS, NetSalary, GrossSalary;
            Console.WriteLine("enter employee number");
            EmpNo = int.Parse(Console.ReadLine());
            Console.WriteLine("enter employee name");
            EmpName = Console.ReadLine();
            Console.WriteLine("enter employee salary");
            Salary = int.Parse(Console.ReadLine());
            if (Salary < 5000)
            {
                HRA = (10 * Salary) / 100;
                TA = (5 * Salary) / 100;
                DA = (15 * Salary) / 100;
            }
            else if (Salary < 10000)
            {
                HRA = (15 * Salary) / 100;
                TA = (10 * Salary) / 100;
                DA = (20 * Salary) / 100;
            }
            else if (Salary < 15000)
            {
                HRA = (20 * Salary) / 100;
                TA = (15 * Salary) / 100;
                DA = (25 * Salary) / 100;
            }
            else if (Salary < 20000)
            {
                HRA = (25 * Salary) / 100;
                TA = (20 * Salary) / 100;
                DA = (30 * Salary) / 100;
            }
            else
            {
                HRA = (30 * Salary) / 100;
                TA = (25 * Salary) / 100;
                DA = (35 * Salary) / 100;
            }
            GrossSalary = Salary + HRA + TA + DA;
            Console.WriteLine("gross salary " + GrossSalary);
            PF = (10 * GrossSalary) / 100;
            TDS = (18 * GrossSalary) / 100;
            NetSalary = GrossSalary - (PF + TDS);
            Console.WriteLine("PF " + PF);
            Console.WriteLine("TDS " + TDS);
            Console.WriteLine("net salary " + NetSalary);
            Console.WriteLine("HRA " + HRA);
            Console.WriteLine("TA " + TA);
            Console.WriteLine("DA " + DA);
            Program p=new Program();
            p.method();
        }
    }
}