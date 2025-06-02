using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PiesSandra.Models;

namespace PiesSandra.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IProductRepository productRepository;

        public HomeController(ILogger<HomeController> logger, IProductRepository productRepository)
        {
            _logger = logger;
            this.productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var products = productRepository.GetAll();
            return View((object)products);
        }

        public IActionResult ProductCard(string id)
        {
            var product = productRepository.TryGetById(int.Parse(id));
            return View("ProductCard", product);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
