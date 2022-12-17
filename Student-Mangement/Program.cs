using Student_Mangement.Helper;
using System;


namespace Student_Mangement
{
    public class Program
    {
        static void Main(string[] args)
        {

            Calculations obj = new Calculations(); // object creation
            obj.SayHello(); // function call                  
            obj.multiplication(10, 200);

            double number = obj.getMeTemp();
            Console.WriteLine(number);
            int x, y;

            Console.WriteLine("Enter two num");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());


            obj.multiplication(x,y);


            Console.ReadKey();
        }
    }
}
