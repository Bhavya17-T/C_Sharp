using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.framework
{
    class program
    {
        public void number()
        {
            Console.WriteLine("enter size of the array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            int[] array2 = new int[size];
            Console.WriteLine("enter the elements of the array");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Copy(array, array2, size);
            Console.WriteLine("elements copied are");
            foreach (int arr in array)
            {
                Console.WriteLine(arr);
            }
            Array.Sort(array);
            Console.WriteLine("Sorted elements are");
            foreach (int arr1 in array)
            {
                Console.WriteLine(arr1);
            }
            Array.Clear(array, 1, 2);
            Console.WriteLine("clear elements");
            foreach (int arr2 in array)
            {
                Console.WriteLine(arr2);
            }
            Array.Reverse(array);
            Console.WriteLine("reversed ellements");
            foreach (int arr3 in array)
            {
                Console.WriteLine((int)arr3);
            }
        }
        public void String()
        {
            Console.WriteLine("enter size of the array");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] string1 = new string[size];
            string[] string2 = new string[size];
            Console.WriteLine("enter the elements of the array");
            for (int i = 0; i < size; i++)
            {
                string1[i] = Console.ReadLine();
            }
            Array.Copy(string1, string2, size);
            Console.WriteLine("elements copied are");
            foreach (string str in string1)
            {
                Console.WriteLine(str);
            }
            Array.Sort(string1);
            Console.WriteLine("Sorted elements are");
            foreach (string str2 in string1)
            {
                Console.WriteLine(str2);
            }
            Array.Clear(string1, 0, 1);
            Console.WriteLine("clear elements");
            foreach (string str3 in string1)
            {
                Console.WriteLine(str3);
            }
            Array.Reverse(string1);
            Console.WriteLine("reversed ellements");
            foreach (string str4 in string1)
            {
                Console.WriteLine(str4);
            }
        }

    }
    public class Employee<A>
    {
        A[] Obj = new A[10];
        int count = 0;
        public void add(A item)
        {
            if (count + 1 < 11)
            {
                Obj[count] = item;
            }
            count++;
            Console.WriteLine("no.of employees" +count);
        }
        public A this[int index]
        {
            get { return Obj[index]; }
            set { Obj[index] = value; }
        }
    }
    class MyStack<t>
    {
        int size;
        t[] stack;
        int top;
        public MyStack()
        {
            size = 10;
            stack = new t[size];
        }
        public int Push(t element)
        {
            if (top == size - 1)
            {
                Console.WriteLine("stack overflows");
            }
            else
            {
                top = top + 1;
                stack[top] = element;
            }
            return 0;
        }
        public t Pop()
        {
            t Removedele;
            t temp = default(t);
            if (top < 0)
            {
                Removedele = stack[top];
                top = top + 1;
                return Removedele;
            }
            return temp;
        }
        public t[] GetStackEle()
        {
            t[] elements = new t[top + 1];
            Array.Copy(stack, 0, elements, 0, top + 1);
            return elements;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            program a = new program();
            a.number();
            a.String();
            Employee<string> emp = new Employee<string>();
            emp.add("navya");
            emp.add("surya");
            emp.add("bhavya");
            emp.add("vishnavi");
            emp.add("amrutha");
            emp.add("monika");
            emp.add("vijayalakshmi");
            emp.add("bhavana");
            emp.add("deepthi");
            emp.add("chaitanya");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Employee details:");
                Console.WriteLine(emp[i]);  
            }
            
            MyStack<string> S = new MyStack<string>();
            while (true)
            {
                Console.WriteLine("1.Push");
                Console.WriteLine("2.Pop");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Enter choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("enter string to push");
                            string temp = Console.ReadLine();
                            int result = S.Push(temp);
                            if (result != -1)
                            {
                                Console.WriteLine("element pushed into stack");
                            }
                            else
                            {
                                Console.WriteLine("stack overflows");
                            }
                            break;

                        }
                    case 2:
                        {
                            string Result = S.Pop();
                            if (Result != null)
                            {
                                Console.WriteLine("delete element; " + Result);
                            }
                            else
                            {
                                Console.WriteLine("stack underflow");
                            }
                            break;
                        }
                    case 3:
                        {
                            System.Diagnostics.Process.GetCurrentProcess().Kill();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("you have entered wrong choice");
                            break;
                        }


                }
            }

        }
    }

}
