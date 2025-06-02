using PiesSandra.Models;

namespace PiesSandra
{
    public interface ICartStorage
    {
        Cart TryGetByUserId(string userId);
        void Add(Product product, string userId);
    }
}
