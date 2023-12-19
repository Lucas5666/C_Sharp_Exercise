using System;
using System.Collections;

namespace Day03
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine(Fun1(2, 2));
            //Console.WriteLine(Fun2(51));
            //Console.WriteLine(Fun3(20,25));
            //Console.WriteLine(Fun4(89));
            //Console.WriteLine(Fun5_2("f kkbbb"));
            //Console.WriteLine(Fun6("abcdefg",2));
            Console.WriteLine(Fun7("abcdefg"));
        }
        /// <summary>
        /// 1. Write a C# Sharp program to compute
        /// the sum of the two numerical values.
        /// If the two values are the same,
        /// return triple their sum.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Fun1(int a, int b)
        {
            if (a == b)
                return 3 * (a + b);
            return a + b;
        }
        /// <summary>
        /// Write a C# Sharp program to get the absolute
        /// difference between n and 51. If n is broader
        /// than 51 return triple the absolute difference.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int Fun2(int a)
        {
            if (a > 51)
                return 3 * (a - 51);
            return 51 - a;
        }
        /// <summary>
        /// Write a C# Sharp program to check two given
        /// integers, and return true if one of them is
        /// 30 or if their sum is 30.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static bool Fun3(int a,int b)
        {

            return (a == 30 || b ==30 ||a + b ==30);
        }
        /// <summary>
        /// Write a C# Sharp program to check a given
        /// integer and return true if it is within 10
        /// of 100 or 200
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static bool Fun4(int a)
        {
            if (Math.Abs(a - 100) <= 10 || Math.Abs(a - 200) <= 10)
                return true;
            else return false;

        }
        //static string Fun5_2(string s)
        //{
        //    if (s.Length > 2)
        //    {
        //        string s2 = s.Substring(0, 2);
        //        if (s2 == "if")
        //            return s;
        //        else return "if" + s;
        //    }

        //    else return "if" + s;

        //}

        //优化
        static string Fun5(string s)
        {
            if (s.Length > 2 && s.Substring(0, 2) == "if")
                return s;
            else return "if" + s;

        }
        /// <summary>
        /// Write a C# Sharp program to remove the
        /// character at a given position in the string.
        /// The given position will be in the range
        /// 0..(string length -1) inclusive.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        //static string Fun6_2(string s,int a)
        //{
        //    if (a >= 0 && a < s.Length)
        //    {
        //        string s1 = s.Substring(0, a);
        //        string s2 = s.Substring(a + 1, s.Length - (a + 1));
        //        return s1 + s2;
        //    }
        //    return s;    
        //}
        //优化
        static string Fun6(string s ,int a)
        {
          return s.Remove(a,1);

        }
        /// <summary>
        /// Write a C# Sharp program to exchange
        /// the first and last characters in a given
        /// string and return the new string.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        //static string Fun7_2(string s)
        //{
        //  string s1 = s.Substring(0, 1);
        //  string s2 = s.Substring(1, s.Length - 2);
        //  string s3 = s.Substring(s.Length - 1, 1);
        //    return s3 + s2 + s1;
        //}
        //优化
        static string Fun7(string s)
        {
            return s.Length > 1 ? s.Substring(s.Length - 1, 1) + s.Substring(1, s.Length - 2) + s.Substring(0, 1) : s;
        }

        //static string Fun8
    }
}