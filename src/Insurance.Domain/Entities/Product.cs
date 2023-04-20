namespace Insurance.Domain.Entities
{
    public class Product
    {
        public Product()
        {
            ProductInCompanies = new HashSet<ProductInCompany>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public ICollection<ProductInCompany> ProductInCompanies { get; set; }
    }
}
