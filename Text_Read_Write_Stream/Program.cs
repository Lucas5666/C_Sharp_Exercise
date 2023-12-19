using System.Text;

namespace Text_Read_Write_Stream;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //string path = "/Users/lucai/Projects/Text_Read_Write_Stream/TextFile3.txt";
        //StreamReader streamReader = new StreamReader(path);

        ////FileStream fileStream = new FileStream(path,FileMode.Open);

        //string line = null;
        //while((line = streamReader.ReadLine()) != null)
        //{
        //    Console.WriteLine(line);

        //}
        //streamReader.Close();
        Console.WriteLine(AddBinary("1010", "1011"));

        Console.WriteLine((int)('h'));
        Console.ReadKey();
       

    }

    public static string AddBinary(string a, string b)
    {
        int indexA = a.Length - 1;
        int indexB = b.Length - 1;
        int add = 0;
        StringBuilder sb = new StringBuilder();

        while (indexA >= 0 || indexB >= 0 || add != 0)
        {
            int digitA = indexA >= 0 ? a[indexA]-'0' : 0;
            int digitB = indexB >= 0 ? b[indexB]-'0' : 0;
            int sum = digitA + digitB + add;

            sb.Append(sum % 2);
            add = sum / 2;
            indexA--;
            indexB--;

        }

        StringBuilder sb2 = new StringBuilder();
        for (int i = sb.Length - 1; i >= 0; i--)
        {
            sb2.Append(sb[i]);
        }
        return sb2.ToString();

    }



}

