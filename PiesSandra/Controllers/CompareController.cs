using Microsoft.AspNetCore.Mvc;

namespace PiesSandra.Controllers
{
    public class CompareController : Controller
    {

        private readonly IProductRepository productRepository;
        private readonly IComparisonRepository compareRepository;
        public CompareController(IProductRepository productRepository, IComparisonRepository compareRepository)
        {
            this.productRepository = productRepository;
            this.compareRepository = compareRepository;
        }

        public IActionResult Index()
        {
            var compare = compareRepository.TryGetByUserId(Constants.UserId);
            return View(compare);
        }

        public IActionResult Add(int id)
        {
            var product = productRepository.TryGetById(id);
            compareRepository.Add(product, Constants.UserId);
            return RedirectToAction("Index");
        }

        public IActionResult Remove(int id)
        {
            var product = productRepository.TryGetById(id);
            compareRepository.Remove(product, Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}
