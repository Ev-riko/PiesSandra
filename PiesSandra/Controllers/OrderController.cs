using Microsoft.AspNetCore.Mvc;
using PiesSandra.Models;

namespace PiesSandra.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICartRepository cartRepository;
        private readonly IOrderRepository orderRepository;

        public OrderController(ICartRepository cartRepository, IOrderRepository orderRepository)
        {
            this.cartRepository = cartRepository;
            this.orderRepository = orderRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Confirm(Order order)
        {
            var existingCart = cartRepository.TryGetByUserId(Constants.UserId);
            order.Cart = existingCart;
            orderRepository.Add(order);
            cartRepository.Clear(Constants.UserId);
            return View();
        }
    }
}
