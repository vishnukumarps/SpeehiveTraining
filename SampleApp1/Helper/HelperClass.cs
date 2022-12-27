using System.Diagnostics;

namespace SampleApp1.Helper
{
    public class HelperClass
    {


        public void WriteToNotePad(string name, int rollNo)
        {

            string Fullpath = Directory.GetCurrentDirectory();
            var data = Fullpath.Split("SampleApp1");


            var fileName = $"{name}.txt";

            var fullPath = data[0] + "SampleApp1\\" + "output\\" + fileName;


            StreamWriter obj = new StreamWriter(fullPath, true);
            obj.WriteLine($"Name:   {name}");
            obj.WriteLine($"RollNo:   {rollNo}");

            obj.Close();

            Process.Start("notepad.exe", fullPath);
        }
    }
}
