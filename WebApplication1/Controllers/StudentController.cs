using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        // GET: StudentController
        public ActionResult Index()
        {
            var st = new Student()
            {
                Name = "Vishnu"
            };

            ViewBag.Name = "hello";
            return View(st);
        }
        [HttpPost]
        public ActionResult Add(string n1,string n2)
        {
           ViewBag.Name = n1;
          
            return View();
        }

    }
}
