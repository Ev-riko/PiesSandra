using PiesSandra.Models;

namespace PiesSandra
{
    public interface IOrderRepository
    {
        public void Add(Order order);
    }
}