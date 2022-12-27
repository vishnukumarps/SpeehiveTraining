using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            int []b =new int[10];
            b[0] = 10;

            string []names =new string[10];
            names[0] = "Vishnu";

            string msg = "Hello-world-Goodmorning";


            string []data = msg.Split("-");

            var x = "Hello";

            Console.WriteLine(data[0]);
            Console.WriteLine(data[1]);
            Console.WriteLine(data[2]);







        }
    }
}
