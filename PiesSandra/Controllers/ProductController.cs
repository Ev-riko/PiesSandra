using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PiesSandra.Models;

namespace PiesSandra.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Index(int id)
        {
            var product = productRepository.TryGetById(id);
            return View(product); 
        }
    }
}
