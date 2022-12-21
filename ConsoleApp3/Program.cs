using System.Net.Mail;
try
{
    MailMessage mail = new MailMessage();
    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

    mail.From = new MailAddress("test.vihsnukumarps@gmail.com");




    mail.To.Add("vishnukumar5417@gmail.com");
    mail.Subject = "Test Email 1212 12";
    mail.Body = "Hello  121212";


    SmtpServer.Port = 587;
    SmtpServer.Credentials = new System.Net.NetworkCredential("test.vishnukumarps@gmail.com", "tEST@1234");
    SmtpServer.EnableSsl = true;

    SmtpServer.Send(mail);

    Console.WriteLine("Email Send Succesfully 12");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
Console.WriteLine("Email Send Succesfully");


System.Diagnostics.Process.Start(@"C:\Users\user\Desktop\A.txt");