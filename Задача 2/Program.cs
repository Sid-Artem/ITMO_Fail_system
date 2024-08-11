using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Задача_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Work\Numbers.txt";
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-10, 10));
                }


            }
            int k=0 ;
            int s = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                   s= Convert.ToInt32(sr.ReadLine());
                   k=k+s;
                    
                }

                        
            }
            Console.WriteLine(k);
            Console.ReadLine();
        }


    }
}     