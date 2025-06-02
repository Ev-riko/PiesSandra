using PiesSandra.Models;

namespace PiesSandra
{
    public class ComparisonsInMemoryRepository : IComparisonRepository
    {
        private List<Comparison> Comparisons = new List<Comparison>();

        public Comparison TryGetByUserId(string userId)
        {
            return Comparisons.FirstOrDefault(x => x.UserId == userId);
        }

        public void Add(Product product, string userId)
        {
            var existingComparison = TryGetByUserId(userId);
            if (existingComparison == null)
            {
                var newComparison = new Comparison
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    ComparisonItems = new List<ComparisonItem> {
                        new ComparisonItem
                        {
                        Id = Guid.NewGuid(),
                        Product = product
                        }
                    }
                };

                Comparisons.Add(newComparison);
            }
            else
            {
                var existingComparisonItem = existingComparison.ComparisonItems.FirstOrDefault(x => x.Product.Id == product.Id);
                if (existingComparisonItem == null)
                {
                    existingComparison.ComparisonItems.Add(new ComparisonItem
                    {
                        Id = Guid.NewGuid(),
                        Product = product
                    });
                }
            }
        }
        public void Remove(Product product, string userId)
        {
            var existingComparison = TryGetByUserId(userId);
            if (existingComparison != null)
            {
                var existingComparisonItem = existingComparison.ComparisonItems.FirstOrDefault(x => x.Product.Id == product.Id);
                if (existingComparisonItem != null)
                {
                    existingComparison.ComparisonItems.Remove(existingComparisonItem);
                }
            }
        }
    }
}
