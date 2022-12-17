using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car o=new Car();
            o.a = 1; // feild
            Console.WriteLine(o.a);

            // property
            o.TopSpeed = 10;
            Console.WriteLine(o.TopSpeed);

            // getter and setter

            o.setPrice(10);
            Console.WriteLine(o.getPrice());



        }
    }
}
