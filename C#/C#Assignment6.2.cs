using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAssignment
{
    public delegate void EmployeeDelegate();
   
    public class MCDelegate
    {
        public static void PetrolAllowance()
        {
            double salary;
            Console.WriteLine("enter salary");
            salary = double.Parse(Console.ReadLine());
            double PA = (8 * salary) / 100;
            Console.WriteLine("petrol allowance: " + PA);
        }
        public static void FoodAllowance()
        {
            double salary;
            Console.WriteLine("enter salary");
            salary = double.Parse(Console.ReadLine());
            double FA = (13 * salary) / 100;
            Console.WriteLine("food allowance : " + FA);
        }
        public static void OtherAllowances()
        {
            double salary;
            Console.WriteLine("enter salary");
            salary = double.Parse(Console.ReadLine());
            double OA = (3 * salary) / 100;
            Console.WriteLine("Other allowance: " + OA);
        }
        public static void Details()
        {
            int EmpId = 1;
            string EmpName = "Navya";
            Console.WriteLine("Employee id :" + EmpId);
            Console.WriteLine("Employee name: " + EmpName);
        }
        static void Main(string[] args)
        {
            MCDelegate M = new MCDelegate();
            EmployeeDelegate emp1 = new EmployeeDelegate(PetrolAllowance);
            EmployeeDelegate emp2 = new EmployeeDelegate(FoodAllowance);
            EmployeeDelegate emp3 = new EmployeeDelegate(OtherAllowances);
            EmployeeDelegate emp4 = new EmployeeDelegate(Details);
            EmployeeDelegate emp5 = emp1 + emp2 + emp3 + emp4;
            emp5();
            

        }
    }
    
}
