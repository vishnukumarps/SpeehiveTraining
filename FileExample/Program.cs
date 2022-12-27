using System;
using System.Diagnostics;
namespace FileExample
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string Fullpath = Directory.GetCurrentDirectory();
            Console.WriteLine(Fullpath);
            var data = Fullpath.Split("FileExample");
            Console.WriteLine(data[0]);
            var fullPath = data[0] + "FileExample\\" + "output\\A.txt";
            StreamWriter obj = new StreamWriter(fullPath, true);
            obj.WriteLine("Name :Vishnu");
            obj.Close();
           
            Console.WriteLine("Done");

     
            Console.WriteLine(fullPath);
            //  Process.Start("notepad.exe", @"C:\Users\user\Source\Repos\SpeehiveTraining\FileExample\Output\A.txt");
              Process.Start("notepad.exe",fullPath);

        }
    }
}
