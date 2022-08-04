using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum bookType
    {
        Magazine,
        Novel,
        ReferenceBook,
        Miscellaneous
    }
    class Program
    {
        public void Array()
        {
            int[] a = new int[10];
            int Sum = 0;
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < 5; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                Sum = Sum + a[i];
            }
            Console.WriteLine("Sum of all elements stored in the array " + Sum);
        }
        public void Swap()
        {
            Console.WriteLine("Enter b value");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c value");
            int c = int.Parse(Console.ReadLine());
            int temp;
            Console.WriteLine("Numbers before swap " + b + c);
            temp = b;
            b = c;
            c = temp;
            Console.WriteLine("Numbers after swap " + b + c);
        }
        public void Circle()
        {
            const double pi = 3.14;
            Console.WriteLine("Enter value od radius r");
            int r = int.Parse(Console.ReadLine());
            double area = pi * r * r;
            double circumference = 2 * pi * r;
            Console.WriteLine("Area of the circle is " + area);
            Console.WriteLine("Circumference of the circle is " + circumference);
        }
        public struct Book
        {
            int bookId;
            string title;
            int price;
            public Book(int bookId, string title, int price)
            {
                this.bookId = bookId;
                this.title = title;
                this.price = price;
            }

            public void DisplayValues()
            {
                Console.WriteLine("bookId : " + this.bookId.ToString());
                Console.WriteLine("title : " + this.title, ToString());
                Console.WriteLine("price : " + this.price, ToString());
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Addition of two numbers is " + (num1 + num2));
            Console.WriteLine("Subtraction of two numbers is " + (num1 - num2));
            Console.WriteLine("Multiplication of two numbers is " + (num1 * num2));
            Console.WriteLine("Division of two numbers is " + (num1 / num2));
            Console.WriteLine("Enter Marks of the Students");
            int Marks, TotalMarks = 0, Max = 0;
            for (int i = 0; i < 5; i++)
            {
                Marks = int.Parse(Console.ReadLine());
                TotalMarks = TotalMarks + Marks;
                if (Marks < 0 || Marks > 100)
                {
                    Console.WriteLine("Not a valid Marks");
                }
                if (Max < Marks)
                {
                    Max = Marks;
                }
            }
            Console.WriteLine("TotalMarks = " + TotalMarks);
            Console.WriteLine("Average marks = " + (TotalMarks / 5));
            Console.WriteLine("Highest marks = " + Max);
            Program p = new Program();
            p.Array();
            p.Swap();
            p.Circle();
            Book book = new Book(2016,"Wings of fire",700);
            book.DisplayValues();
            Console.WriteLine(" The type of book is " + bookType.Novel);
        }
    }
}

