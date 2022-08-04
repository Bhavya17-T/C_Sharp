using System;
using EmpManagementSystem;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManagementSystem
{
     class Employee
     {
       public string Name;
       public double Salary,NetSalary,PF,TDS,GrossSalary;
        
        public void employee()
        {
            Console.WriteLine("enter name");
            Name = Console.ReadLine();  
        }
     }
    class Manager: Employee
    {
        
        public double PetrolAllowance ;
        public double FoodAllowance ;
        public double OtherAllowance ;
        public void  manager()
        {
            Console.WriteLine("enter salary");
            Salary = double.Parse(Console.ReadLine());
            PetrolAllowance = (8 * Salary) / 100;
            Console.WriteLine("PetrolAllowance allowances:" +PetrolAllowance);
            FoodAllowance = (13 * Salary) / 100;
            Console.WriteLine("food allowances: " +FoodAllowance);
            OtherAllowance = (3 * Salary) / 100;
            Console.WriteLine("other allowances: " +OtherAllowance);
            GrossSalary = Salary+PetrolAllowance+FoodAllowance+OtherAllowance;
            Console.WriteLine("GrossSalry of Manager: " + GrossSalary);
            PF = (10 * Salary) / 100;
            Console.WriteLine("PF of manager: " +PF);
            TDS = (18 * Salary) / 100;
            Console.WriteLine("TDS of manager: " + TDS);
        }
        public void CalculateSalary()
        {
            NetSalary = GrossSalary - (PF + TDS);
            Console.WriteLine("NetSalary: " +NetSalary);
        }
      
        
    }
    class MarketingExecutive : Manager
    {
        double KilometerTravel;
        double TourAllowances;
        double TelephoneAllowances;
        public void marketingExecutive()
        {
            Console.WriteLine("enter salary");
            Salary = double.Parse(Console.ReadLine());
            Console.WriteLine("enter kilo meters");
            KilometerTravel = double.Parse(Console.ReadLine());
            TourAllowances = 5*KilometerTravel;
            Console.WriteLine("TourAllowances allowances: " +TourAllowances);
            TelephoneAllowances = 1000;
            Console.WriteLine("Telephone allowances: " +TelephoneAllowances);
            GrossSalary = Salary + TourAllowances + TelephoneAllowances;
            Console.WriteLine("GrossSalary of marketing executive: " +GrossSalary);
            PF= (10* Salary) / 100;
            Console.WriteLine("PF of Marketing executive: " + PF);
            TDS = (18 * Salary) / 100 ;
            Console.WriteLine("TDS of Marketing executive: " + TDS);
             void CalculateSalary()
             {
                NetSalary = GrossSalary - (PF + TDS);
                Console.WriteLine("NetSalary: " + NetSalary);
             }
        }
        
    }
    public interface IEmployee
    {
       void DisplayEmployeeDetails();
    }
    class clsEmployee : IEmployee
    {
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Displaying employee details...");
            
        }
    }
    class MyStack
    {
        static readonly int max = 1000;
        int top;
        int[] stack = new int[max]; 
        bool IsEmpty()
        {
            return (top < 0);
        }
        public MyStack()
        {
            top = -1;
        }
        internal bool Push(int Data)
        {
            if(top >= max)
            {
                Console.WriteLine("Stack overflows");
                return false;
            }
            else
            {
                stack[++top] = Data;
                return true;
            }
        }
        internal int Pop()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack underflows");
                return 0;
            }
            else
            {
                int value = stack[top];
                return value;
            }
        }
        internal void PrintStack()
        {
            if(top< 0)
            {
                Console.WriteLine("Stack underflow");
                return;
            }
            else
            {
                Console.WriteLine("items in the stack are  ");
                for(int i = top; i >=0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }

    }
    class StackException
    {
        static readonly int max = 1000;
        int top;
        int[] stack = new int[max];
        bool IsEmpty()
        {
            return (top < 0);
        }
        public StackException()
        {
            top = -1;
        }
        internal bool Push(int Data)
        {
            if (top >= max)
            {
                throw new Exception("stack overflows");
            }
            else
            {
                stack[++top] = Data;
                return true;
            }
        }
        internal int Pop()
        {
            if (top < 0)
            {
               throw new Exception("stack under flows");
            }
            else
            {
                int value = stack[top];
                return value;
            }
        }
        internal void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack underflow");
                return;
            }
            else
            {
                Console.WriteLine("items in the stack are  ");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }

    }



    class Program
        {
             static void Main(string[] args)
             {
                 Employee employee = new Employee();
                 Manager M = new Manager();
                 MarketingExecutive M1 = new MarketingExecutive();
                 IEmployee I = new clsEmployee();
                 MyStack S = new MyStack();
                 employee.employee();
                 M.manager();
                 M.CalculateSalary();
                 M1.marketingExecutive();
                 M1.CalculateSalary();
                 I.DisplayEmployeeDetails();
                 S.Push(10);
                 S.Push(20);
                 S.Push(30);
                 S.Push(40);
                 Console.WriteLine("pushed elements");
                 S.PrintStack();
                 Console.WriteLine("item poped from stack is : {0}", S.Pop());
                 string S1 = "bhavya";
                 string S2 = (String)S1.Clone();
                 Console.WriteLine("String : " + S1);
                 Console.WriteLine("Clone String : " + S2);
                 StackException SE = new StackException();
                 int num;
                 try
                 {
                   num= SE.Pop();
                 }
                 catch
                 {
                    Console.WriteLine("stack underflows what to do now");
                 }
                 
                 

             }
        }
}
