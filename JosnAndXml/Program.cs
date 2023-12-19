using System;
using System.Collections;
using NPOI.SS.Formula.Functions;

public class Solution
{
    static void Main()
    {
        //string[] sa = new string[] { "flower", "flow", "flight" };

        //string a = LongestCommonPrefix(sa);
        //string s1 = "";
        //Console.WriteLine(s1.Length);
        int a = MySqrt(2147395599);
        Console.WriteLine(a);


        Console.ReadKey();
    }
    public static string LongestCommonPrefix(string[] strs)
    {
        int count = 0;
        string stringFinal = "";
        bool s = false;
        int min = 0;

        if (strs.Length == 1)
        {
            return strs[0];
        }

        for (int k = 0;k < strs.Length - 1; k++)
        {
            min = strs[0].Length;

            if(strs[k].Length > strs[k + 1].Length)
            {
                min = strs[k + 1].Length;
            }
        }

        for (int i = 0; i <= min; i++)
        {
            for (int j = 0; j < strs.Length - 1; j++)
            {
                if(strs[j] != null && strs[j + 1] != null)
                {
                    if (strs[j][i] != strs[j + 1][i])
                    {
                        s = true;
                        break;
                    }
                }
                else
                {
                    return "";
                }
                

                
            }

            if (s)
            {
                if (count == 0)
                    return stringFinal = "";
                else
                {
                    stringFinal = strs[0].Substring(0, count);
                }
                return stringFinal;

                //break;
            }
            else
                count++;

        }
        return stringFinal;

    }

    public static int MySqrt(int x)
    {
        int left = 0;
        int right = x;
        int half = 0;
        if (x <= 1)
        {
            return x;
        }

        while (right - left > 1)
        {

            half = (left + right) / 2;

            if (half * half == x)
            {
                return half;
            }

            else if (half * half > x)
            {
                right = half;
            }
            else
            {
                left = half;
            }
        }
        return left;

    }
}




