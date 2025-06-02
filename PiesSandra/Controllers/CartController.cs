using Microsoft.AspNetCore.Mvc;

namespace PiesSandra.Controllers
{
    public class CartController : Controller
    {

        private readonly IProductRepository productRepository; 
        private readonly ICartRepository cartRepository; 

        public CartController(IProductRepository productRepository, ICartRepository cartRepository)
        {
            this.productRepository = productRepository;
            this.cartRepository = cartRepository;
        }

        public IActionResult Index()
        {
            var cart = cartRepository.TryGetByUserId(Constants.UserId);
            return View(cart);
        }

        public IActionResult Add(int id)
        {
            var product = productRepository.TryGetById(id);
            cartRepository.Add(product, Constants.UserId);
            return RedirectToAction("Index");
        }

        public IActionResult Remove(int id)
        {
            var product = productRepository.TryGetById(id);
            cartRepository.Remove(product, Constants.UserId);
            return RedirectToAction("Index");
        }

        public IActionResult Clear()
        {
            cartRepository.Clear(Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}
