using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    class Program
    {
        static void Main1()
        {
            Console.WriteLine("你好，世界");
            string input = Console.ReadLine();
            Console.WriteLine(input);
            Console.ReadLine();
            Console.WriteLine(input);

        }

        static void Main()
        {
            float num01 = 3.0f;
            float num02 = 2.9f;
            float result = num01 - num02;
            bool b1 = result == 0.1f;
            Console.WriteLine(b1);

        }
    }
}