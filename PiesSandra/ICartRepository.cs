using PiesSandra.Models;

namespace PiesSandra
{
    public interface ICartRepository
    {
        void Add(Product product, string userId);
        void Clear(string userId);
        void Remove(Product product, string userId);
        Cart TryGetByUserId(string userId);
    }
}