using Microsoft.AspNetCore.Mvc;
using PiesSandra.Controllers;

namespace PiesSandra.Views.Shared.ViewComponents.CartViewCpmponents
{
    public class CartViewComponent : ViewComponent
    {
        private readonly ICartRepository cartRepository;

        public CartViewComponent(ICartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }

        public IViewComponentResult Invoke()
        {
            var cart = cartRepository.TryGetByUserId(Constants.UserId);
            var productCount = cart?.Amount;

            return View("Cart" ,productCount);
        }
    }
}
