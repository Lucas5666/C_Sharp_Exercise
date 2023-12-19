// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

FileInfo myfile = new FileInfo(@"/Users/lucai/Projects/File/TextFile.txt");

//myfile.CopyTo(@"/Users/lucai/Projects/File/TextFile2.txt");

DirectoryInfo myFolder = new DirectoryInfo(@"/Users/lucai/Projects/File/create");
myFolder.Create();

Console.WriteLine(myFolder.Exists);

Directory.CreateDirectory("Create2/child");

Console.WriteLine(myFolder.FullName);

//string str = File.ReadAllText(@"/Users/lucai/Projects/File/TextFile.txt",System.Text.Encoding.UTF8);

//Console.WriteLine(str);

//string[] v = File.ReadAllLines(@"/Users/lucai/Projects/File/TextFile.txt");
//foreach (var item in v)
//{
//    Console.WriteLine(item);
//}

//byte[] bArray = File.ReadAllBytes(@"/Users/lucai/Projects/File/TextFile.txt");
//foreach (var item in bArray)
//{
//    Console.WriteLine(item);
//}

File.WriteAllText(@"/Users/lucai/Projects/File/TextFile.txt", "nihao shijie");
Console.WriteLine(File.ReadAllText(@"/Users/lucai/Projects/File/TextFile.txt"));
File.WriteAllLines(@"/Users/lucai/Projects/File/TextFile.txt",new string[] {"1111","2222","3333"});
Console.WriteLine(File.ReadAllText(@"/Users/lucai/Projects/File/TextFile.txt"));
Console.ReadKey();
