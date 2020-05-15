using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ReadFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            var app = new Program();

            //read first file
            string[] file1 = File.ReadAllLines(@"C:\Users\mmhso\source\repos\ReadFiles\ReadFiles\files\file1.txt");
            //read second file
            string[] file2 = File.ReadAllLines(@"C:\Users\mmhso\source\repos\ReadFiles\ReadFiles\files\file2.txt");

            //dispaly first file
            Console.WriteLine("below file1");
            for (var i = 0; i < file1.Length; i++)
            {
                Console.WriteLine(file1[i]);
            }
            //display second file
            Console.WriteLine("below file2");
            for (var i = 0; i < file2.Length; i++)
            {
                Console.WriteLine(file2[i]);
            }

            //mix files 
            Console.WriteLine("below both file one and file2");
            string[] mixedArray = new string[file1.Length + file2.Length];
            Array.Copy(file1, mixedArray, file2.Length);
            Array.Copy(file2, 0, mixedArray, file1.Length, file2.Length);

            //dispaly the mixed file
            for (var i = 0; i < mixedArray.Length; i++)
            {
                Console.WriteLine(mixedArray[i]);
            }
            //sort the mixed file and display it 
            Console.WriteLine("below the mixed file sorted alphabetically");
            var sortAlpha = mixedArray.OrderBy(n => n);
            foreach (var item in sortAlpha)
            {
                Console.WriteLine(item);
            }

            Console.Read();   
        }
    }
}
