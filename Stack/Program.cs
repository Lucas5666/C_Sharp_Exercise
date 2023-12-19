using System;
using System.Collections;

namespace Stack
{
    class Program
    {
        static void Main1()
        {
            Stack<char> stack = new Stack<char>();
            stack.Push('a');
            stack.Push('b');
            stack.Push('c');
            Console.WriteLine("数据的个数为： " + stack.Count);
            char temp = stack.Pop();
            Console.WriteLine(temp);
            //Console.WriteLine();
            Console.WriteLine("数据的个数为： " + stack.Count);
            char temp2 = stack.Peek();
            Console.WriteLine(temp2);
            Console.WriteLine("数据的个数为： " + stack.Count);
            stack.Clear();
            Console.WriteLine("数据的个数为： " + stack.Count);
            //char temp3 = stack.Peek();
            //Console.WriteLine(temp3);

            Console.ReadKey();
        }
        static void Main2()
        {
            SeqStack<char> stack = new SeqStack<char>();
            stack.Push('a');
            stack.Push('b');
            stack.Push('c');
            Console.WriteLine("数据的个数为： " + stack.Count);
            char temp = stack.Pop();
            Console.WriteLine(temp);
            //Console.WriteLine();
            Console.WriteLine("数据的个数为： " + stack.Count);
            char temp2 = stack.Peek();
            Console.WriteLine(temp2);
            Console.WriteLine("数据的个数为： " + stack.Count);
            stack.Clear();
            Console.WriteLine("数据的个数为： " + stack.Count);
            //char temp3 = stack.Peek();
            //Console.WriteLine(temp3);

            Console.ReadKey();
        }
        static void Main()
        {
            IStackDS<char> stack = new LinkStack<char>();

            stack.Push('a');
            stack.Push('b');
            stack.Push('c');
            Console.WriteLine("数据的个数为： " + stack.Count);
            char temp = stack.Pop();
            Console.WriteLine(temp);
            //Console.WriteLine();
            Console.WriteLine("数据的个数为： " + stack.Count);
            char temp2 = stack.Peek();
            Console.WriteLine(temp2);
            Console.WriteLine("数据的个数为： " + stack.Count);
            stack.Clear();
            Console.WriteLine("数据的个数为： " + stack.Count);
            //char temp3 = stack.Peek();
            //Console.WriteLine(temp3);

            Console.ReadKey();
        }
    }
}