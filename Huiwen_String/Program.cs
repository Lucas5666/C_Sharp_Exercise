using System;
using System.Collections.Generic;

namespace StackAndQueue
{
    class program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();
            for(int i = 0; i < str.Length; i++)
            {
                stack.Push(str[i]);
                queue.Enqueue(str[i]);
            }
            bool isHuiWen = true;

            while (stack.Count > 0)
            {

                if (stack.Pop() != queue.Dequeue())
                {
                    isHuiWen = false;
                    break;
                }

            }

            Console.WriteLine("是否为回文 ：{0}",isHuiWen);
            Console.ReadKey();
           
        }
    }
}