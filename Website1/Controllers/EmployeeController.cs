using Microsoft.AspNetCore.Mvc;

namespace Website1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddDetails( string firstName1,string secondName1, string msg1)
        {
            ViewBag.Name=firstName1 + " " + secondName1;




            return View();
        }
    }
}
