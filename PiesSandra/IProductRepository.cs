using PiesSandra.Models;

namespace PiesSandra
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product TryGetById(int id);
    }
}
