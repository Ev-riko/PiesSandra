namespace PiesSandra.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public List<CartItem> CartItems { get; set; }
        public decimal TotalCost
        {
            get
            {
                return CartItems?.Select(x => x.TotalCost).Sum() ?? 0;
            }
        }

        public decimal Amount
        {
            get
            {
                return CartItems?.Sum(x => x.Amount) ?? 0;
            }
        }
    }
}
