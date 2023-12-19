using System;
using System.Collections.Generic;

namespace Queue
{
    static class SeqQueue
    {
        static void Main()
        {
            LinkQueue<char> stack = new LinkQueue<char>();
            stack.Enqueue('a');
            stack.Enqueue('b');
            stack.Enqueue('c');
            Console.WriteLine("数据的个数为： " + stack.Count);
            char temp = stack.Dequeue();
            Console.WriteLine(temp);
            //stack.Dequeue();
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