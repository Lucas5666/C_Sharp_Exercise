using System;
using System.Threading.Tasks;

namespace Day05Linked_List
{
	public class Test
	{
        static void Main(string[] args)
        {
            LinkList<string> seqList = new LinkList<string>();

            seqList.Add("123");
            seqList.Add("456");
            seqList.Add("789");

            Console.WriteLine(seqList[0]);
            Console.WriteLine(seqList.GetEle(0));

            seqList.Insert("555", 2);
            for (int i = 0; i < seqList.GetLength(); i++)
            {
                Console.WriteLine(seqList[i]);
            }

            seqList.Clear();
            Console.WriteLine(seqList.GetLength());
            Console.WriteLine(seqList.IsEmpty());


            Console.ReadKey();
        }

     
	}
}

