using System;
using System.Collections.Generic;
using System.Text;

namespace A098_Stacklmplementation
{

    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                int val = r.Next(100);
                stack.Push(val);
                Console.WriteLine("Push(" + val + ") ");
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
                Console.Write("Pop()=" + stack.Pop() + ",");
        }
    }
}
