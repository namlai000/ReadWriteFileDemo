using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteFileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with Directiry");
            DirectoryInfo dir = new DirectoryInfo("D:\\Source\\CNW\\Final - NetWork");
            Console.WriteLine("Full name: {0}", dir.FullName);
            Console.WriteLine("Name: {0}", dir.Name);
            

            FileInfo[] bitmapFiles = dir.GetFiles("*.png");
            Console.WriteLine("Found {0} png files", bitmapFiles.Length);

            foreach (FileInfo f in bitmapFiles)
            {
                Console.WriteLine("Filename: {0}", f.Name);
            }

            DirectoryInfo d = dir.CreateSubdirectory("MyFoo");
            Console.ReadLine();
        }
    }
}
