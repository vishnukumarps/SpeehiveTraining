using Microsoft.AspNetCore.Mvc;

namespace Website1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
