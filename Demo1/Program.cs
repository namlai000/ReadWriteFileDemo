using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string root = "D:\\";
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("1. Create a folder");
                Console.WriteLine("2. Create a text file");
                Console.WriteLine("3. Write to file");
                Console.WriteLine("4. Read from file");
                Console.WriteLine("5. Exit");
                Console.Write("Choose: ");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        DirectoryInfo dir = new DirectoryInfo(root);
                        Console.Write("Enter folder name: ");
                        string folder = Console.ReadLine();
                        DirectoryInfo d = dir.CreateSubdirectory(folder);
                        Console.WriteLine("Your folder is created");
                        break;
                    case 2:
                        Console.Write("Enter file name: ");
                        string file = Console.ReadLine();
                        FileStream fs = File.Open(root + file, FileMode.Create);
                        Console.WriteLine("Your file is created");
                        break;
                    case 3:
                        Console.Write("Enter your file name: ");
                        string file1 = Console.ReadLine();
                        FileInfo f = new FileInfo(root + file1);
                        if (f.Exists)
                        {
                            StreamWriter writer = new StreamWriter(f.FullName, true);
                            Console.Write("Enter your message: ");
                            string msg = Console.ReadLine();
                            writer.WriteLine(msg);
                            writer.Close();
                        }
                        else
                        {
                            Console.WriteLine("File not exist or can not read");
                        }
                        break;
                    case 4:
                        Console.Write("Enter your file name: ");
                        string file2 = Console.ReadLine();
                        FileInfo f1 = new FileInfo(root + file2);
                        if (f1.Exists)
                        {
                            StreamReader reader = new StreamReader(f1.FullName);
                            Console.WriteLine("Your message: ");
                            string input = null;
                            while ((input = reader.ReadLine()) != null)
                            {
                                Console.WriteLine(input);
                            }
                            reader.Close();
                        }
                        else
                        {
                            Console.WriteLine("File not exist or can not read");
                        }
                        break;
                    default:
                        loop = false;
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
