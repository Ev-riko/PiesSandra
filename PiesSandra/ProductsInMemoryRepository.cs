using PiesSandra.Models;
using System.Linq;

namespace PiesSandra
{
    public class ProductsInMemoryRepository : IProductRepository
    {
        private List<Product> Products = new List<Product>()
        {
            new Product( "kartofjin", 500, "kartofjin kartofjin kartofjin", "/images/ualibax.png"),
            new Product( "ualibax", 550, "ualibax ualibax ualibax", "/images/ualibax.png"),
            new Product( "caharajin", 450, "caharajin caharajin caharajin", "/images/ualibax.png"),
            new Product( "nahjin", 600, "nahjin nahjin nahjin", "/images/ualibax.png"),
            new Product( "fidjin", 800, "fidjin fidjin fidjin", "/images/ualibax.png")
        };

        public List<Product> GetAll()
        {
            return Products;
        }

        public Product TryGetById(int id)
        {
            return Products.FirstOrDefault(p => p.Id == id);
        }
    }
}
