
using WebApplication1.Models;

namespace StudentMangementExample2.Helper
{
    public class HelperClass
    {
        public void WriteToFile(Student s1)
        {
            // file write
            StreamWriter ob = new StreamWriter(@"C:\Users\Dell E6520\Desktop\Test1.txt", true);

            ob.WriteLine("HAi");
            ob.Close();
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
