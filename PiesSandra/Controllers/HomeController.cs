using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PiesSandra.Models;

namespace PiesSandra.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IProductRepository productRepository;
        private readonly ICartRepository cartRepository;

        public HomeController(ILogger<HomeController> logger, IProductRepository productRepository, ICartRepository cartRepository)
        {
            _logger = logger;
            this.productRepository = productRepository;
            this.cartRepository = cartRepository;
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
