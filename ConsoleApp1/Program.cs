using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Path.GetTempPath());
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine(path);
            var currentDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Console.WriteLine(currentDirectory);

            Console.WriteLine(Thread.GetDomain().BaseDirectory);
            Console.WriteLine($"Launched from {Environment.CurrentDirectory}");
            Console.WriteLine($"Physical location {AppDomain.CurrentDomain.BaseDirectory}");
            Console.WriteLine($"AppContext.BaseDir {AppContext.BaseDirectory}");
            Console.WriteLine($"Runtime Call {Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName)}");

            Console.WriteLine(System.Reflection.Assembly.GetEntryAssembly().GetName().Name);
            var pName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
            Console.WriteLine(System.Reflection.Assembly.GetEntryAssembly().GetName());
            
            
            
            Console.WriteLine(path.Split(pName)[0]);
           
            
            System.Diagnostics.Process.Start("notepad.exe", @"E:\A\test.txt");




        }
    }
}
