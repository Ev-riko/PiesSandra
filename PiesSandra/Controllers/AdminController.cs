using Microsoft.AspNetCore.Mvc;

namespace PiesSandra.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Orders");
        }

        public IActionResult Orders()
        {
            return View("Orders");
        }
        public IActionResult Users()
        {
            return View("Users");
        }
        public IActionResult Products()
        {
            return View("Products");
        }
        public IActionResult Roles()
        {
            return View("Roles");
        }
    }
}
