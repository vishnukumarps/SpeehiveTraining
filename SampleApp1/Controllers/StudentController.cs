using Microsoft.AspNetCore.Mvc;
using SampleApp1.Helper;

namespace SampleApp1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult Sum(int a, int b)
        {

            int ans = a + b;


            ViewBag.Ans1 = ans;

            return View();
        }


        public IActionResult AddDetails( string studnetName, int rollNo)
        {
       


            ViewBag.StudentName1 = studnetName;
            ViewBag.RollNo2 = rollNo;


            HelperClass obj = new HelperClass();
            obj.WriteToNotePad(studnetName,rollNo);

            return View();
        }

    }
}
