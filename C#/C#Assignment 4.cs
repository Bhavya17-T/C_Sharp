using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
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
        
    }
    class program
    {
        static void Main(string[] args)
        {
            StackException SE = new StackException();
            int num;
            try
            {
                num = SE.Pop();
            }
            catch
            {
                Console.WriteLine("stack underflows what to do now");
            }

        }
    }
}
