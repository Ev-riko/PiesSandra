namespace PiesSandra.Models
{
    public class Comparison
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public List<ComparisonItem> ComparisonItems { get; set; }
    }
}
