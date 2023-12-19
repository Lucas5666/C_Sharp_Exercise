using System;
using System.Collections.Generic;


namespace Day02
{
    class Program
    {
       
        static void Main1()
        {
            string num01 = "10";
            string num02 = "20";

            string str = string.Format("抢的数量是：{0}，容量是：{1}。", num01, num02);
            Console.WriteLine(str);

            Console.WriteLine("金额：{0:c}", 10);
            Console.WriteLine("{0:d2}", 5);
            Console.WriteLine("{0:f1}", 1.26);
            Console.WriteLine("{0:p0}", 0.12);
            Console.WriteLine("我爱\"Unity!\"");

            float n1 = 5;
            int n2 = 2;
            float n3 = n1 / n2;
            Console.WriteLine(n3);

            int i4 = 254;
            byte b4 = (byte)i4;

            


            Console.ReadLine();

        }

        static void Main()
        {
            int[] arr1 = new int[6];
            arr1[0] = 3;
            arr1[1] = 1;
            arr1[2] = 17;
            arr1[3] = 7;
            arr1[4] = 5;
            arr1[5] = 6;

            //Console.WriteLine(arr1[5]);

            int a = GetMax(arr1);
            //Console.WriteLine(a);
            //SortMax(arr1);
            SortMin(arr1);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

             foreach(int item in arr1)
            {
                Console.WriteLine(item);

            }

            Console.ReadLine();

        }
        private static int GetMax(int[] arr)
        {
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }


            return max;
        }

        private  static int[] SortMax(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {


                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int tem;

                        tem = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tem;
                    }
                }
            }
            return arr;
        }

        private static int[] SortMin(int[] arr)
        {
            for (int curretIndex = 0; curretIndex < arr.Length; curretIndex++)
            {
                int maxIndex = curretIndex;

                for (int i = curretIndex; i < arr.Length; i++)
                {
                    if (arr[maxIndex] < arr[i])
                    {
                        maxIndex = i;
                    }
                }
                if (maxIndex != curretIndex)
                {
                    int tem = arr[curretIndex];
                    arr[curretIndex] = arr[maxIndex];
                    arr[maxIndex] = tem;

                }
            }

            return arr;
        }
    }
}