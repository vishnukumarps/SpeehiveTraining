using StudentMangementExample2.Model;

namespace StudentMangementExample2.Helper
{
    public class HelperClass
    {


        public Student GetStudentDetails()
        {
            int a;
            a = 10;
            Student s1 = new Student();

            Console.WriteLine("Enter student Name");
            s1.Name=Console.ReadLine();

            Console.WriteLine("Enter Mob");
            s1.Mob=Console.ReadLine();

            Console.WriteLine("Enter m1 and m2");
            s1.M1=Convert.ToInt32(Console.ReadLine());
            s1.M2 = Convert.ToInt32(Console.ReadLine());



            return s1;
        }


        public void DisplayStudentDetailsInScreen(Student s1)
        {
            Console.WriteLine($"Name  : {s1.Name}");
            Console.WriteLine($"Age  : {s1.Age}");
            Console.WriteLine($"Address  : {s1.Address}");
        }
















        public void WriteToFile(Student s1)
        {
            // file write
        }

        public void SendEmail(Student s1)
        {
            // code of email sending
        }

        public void SendSMS()
        {

        }

        public void CreatePdf(Student s1)
        {

        }

    }
}
