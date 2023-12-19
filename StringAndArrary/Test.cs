using System;
namespace StringAndArray
{
    public class Test
    {

        public static void Main()
        {
            //string[] sa = new string[] { "flower", "flow", "flight" };

            //string[] sb = new string[] { "flower", "flower", "flower", "flower", };

            //string[] sc = new string[] { "ca", "c", "bba", "bacb", "bcb" };
            //Console.WriteLine(LongestCommonPrefix(sa));
            //Console.WriteLine(LongestCommonPrefix(sb));
            //Console.WriteLine(LongestCommonPrefix(sc));

            int b = StrStr("mississippi", "issip");
            Console.WriteLine(b);


            Console.ReadKey();
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            
            int min = 0;
            int minindex = 0;
            string stringFinal;

            if (strs == null)
                return "";
            if (strs.Length == 1)
                return strs[0];
            

            for (int i = 0; i < strs.Length - 1; i++)
            {
                min = strs[0].Length;

                if (min > strs[i + 1].Length)
                {
                    min = strs[i + 1].Length;
                    
                }
                minindex = min - 1;
            }
            if (min == 0)
                return "";
            for(int j = 0; j < min; j++)
            {
                foreach (var s in strs)
                {
                    if (!s.StartsWith(strs[0].Substring(0,minindex+1)))
                    {
                        minindex--;
                        break;
                    }
                }
                
            }

            stringFinal = strs[0].Substring(0, minindex + 1);
            return stringFinal;

  
        }

        public static int StrStr(string haystack, string needle)
        {
            List<char> a = new List<char>();
            string b = null;

            for (int i = 0; i < (haystack.Length - needle.Length) + 1; i++)
            {
                if (haystack[i] == needle[0])
                {
                    for (int j = i; j < i + needle.Length; j++)
                    {
                        a.Add(haystack[j]);

                    }
                    b = string.Join("", a);

                    if (b == needle)
                    {
                        return i;
                    }
                    else
                    {
                        a.Clear();
                        continue;
                    }

                }
            }
            return -1;


        }
    }
}

