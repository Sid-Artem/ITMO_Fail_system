using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Work\Task3.txt";
            int charNumber = 0;

            using (var reader = new StreamReader(path, detectEncodingFromByteOrderMarks: true))
            {
                while (reader.Read() > 0)
                {
                    charNumber++;
                }
            }
            Console.WriteLine(charNumber);
            Console.ReadLine();

        }
    }
}
