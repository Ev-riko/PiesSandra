using PiesSandra.Models;

namespace PiesSandra
{
    public class OrdersInMemoryRepository : IOrderRepository
    {
        private List<Order> orders = new List<Order>();
        
        public void Add(Order order)
        {
            orders.Add(order);
        }
    }
}
