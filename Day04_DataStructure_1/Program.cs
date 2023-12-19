using System;
namespace Day04_DataStructure_1
{
    class Program
    {
        static void Main1(string[] args)
        {
            List<string> strList = new List<string>();

            strList.Add("123"); //0
            strList.Add("456");
            strList.Add("789");

            Console.WriteLine(strList[0]);
            strList.Remove("789");
            strList.Clear();
            Console.WriteLine(strList.Count);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            SeqList<string> seqList = new SeqList<string>();

            seqList.Add("123");
            seqList.Add("456");
            seqList.Add("789");

            Console.WriteLine(seqList[0]);
            Console.WriteLine(seqList.GetEle(0));

            seqList.Insert("555", 2);
            for(int i = 0; i < seqList.GetLength(); i++)
            {
                Console.WriteLine(seqList[i]);
            }

            seqList.Clear();
            Console.WriteLine(seqList.GetLength());

            Console.ReadKey();
        }
    }
}