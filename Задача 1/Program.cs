using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace Задача_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Work";
            string [] files = Directory.GetFiles(path,"*",SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadLine();
        }
    }
}
