namespace crud.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductCategory Category { get; set; }
    }

    public enum ProductCategory
    {
        Food = 0,
        Conveniece = 1,
        Commodites = 2,
        Durables = 3,
        Digital = 4

    }
}
