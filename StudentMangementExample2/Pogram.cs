using StudentMangementExample2.Helper;
using StudentMangementExample2.Model;

namespace StudentMangementExample2
{
    internal class Pogram
    {
        static void Main(string[] args)
        {
            HelperClass helper = new HelperClass();
         
            Student s1= helper.GetStudentDetails();

            s1.Name = s1.Name + "Speehive";

            helper.DisplayStudentDetailsInScreen(s1);


        }
    }
}
