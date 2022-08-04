using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file__IO
{
    class class1
    {
        public interface IEmployee
        {
            void ShowDetails();
        }
    }
        public class Manager
        {
            private int Id;
            private string Name;
            private double Salary;
            public Manager()
            {
                Console.WriteLine("Enter Id:");
                Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name:");
                Name = Console.ReadLine();
                Console.WriteLine("Enter Salary:");
                Salary =double.Parse(Console.ReadLine());
            }
            public void ShowDetails()
            {
                Console.WriteLine("Id :" + Id);
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Salary" + Salary);
            }     
        }
    
    class Program
    {
        static void Main(string[] args)
        {
             void SerializeData()
            {
                string S = "Welcome to C#";
                FileStream fileStream = new FileStream(@"C:\Users\SRI NAVYA - SURYA\Desktop\test.txt", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, S);
                fileStream.Close();
            }
             void DeSerializeData()
            {
                FileStream fileStream = new FileStream(@"C:\Users\SRI NAVYA - SURYA\Desktop\test.txt", FileMode.Open);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                string data = "";
                data = (string)binaryFormatter.Deserialize(fileStream);
                fileStream.Close();
                Console.WriteLine("your deserialize data is");
                Console.WriteLine(data);
            }
            class1 C = new class1();
            Manager manager = new Manager();
            manager.ShowDetails();
            SerializeData();
            DeSerializeData();
            Console.ReadLine();

        }
    }
    
        
}
