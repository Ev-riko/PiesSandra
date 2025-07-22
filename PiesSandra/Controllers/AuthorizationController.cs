using Microsoft.AspNetCore.Mvc;
using PiesSandra.Models;

namespace PiesSandra.Controllers
{
    public class AuthorizationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Select(int id)
        {
            if (id == 0)
                return View("SingIn");
            else
                return View("SingUp");
        }

        public IActionResult SingIn(User user)
        {
            return View("SingIn");
        }

        public IActionResult SingUp(User user)
        {
            return View("SingUp");
        }
    }
}
