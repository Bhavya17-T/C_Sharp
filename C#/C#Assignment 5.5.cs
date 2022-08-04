using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.framework
{
    
       


    class Program
    {
        static void Main(string[] args)
        {
            //search employee name in the list
            List<string> Employeelist = new List<string>();
            Employeelist.Add("navya");
            Employeelist.Add("surya");
            Employeelist.Add("bhavya");
            Employeelist.Add("vishnavi");
            Employeelist.Add("amrutha");
            Employeelist.Add("monika");
            Employeelist.Add("vijayalakshmi");
            Employeelist.Add("bhavana");
            Employeelist.Add("deepthi");
            Employeelist.Add("chaitanya");
            Console.WriteLine(Employeelist.Contains("navya"));
            
            
             

            




        }
    }
}


