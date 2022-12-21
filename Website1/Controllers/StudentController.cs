using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Website1.Controllers
{
    public class Student : Controller
    {
        // GET: StudentController

        public string hai()
        {
            return "1";
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Page2()
        {
            return View();
        }




    }
}
