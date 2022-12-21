using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            System.Diagnostics.Process.Start("notepad.exe", @"E:\A\test.txt");
        }
    }
}
