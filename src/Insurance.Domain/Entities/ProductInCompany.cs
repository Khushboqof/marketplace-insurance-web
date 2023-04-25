namespace Insurance.Domain.Entities
{
    public class ProductInCompany
    {
        public ProductInCompany()
        {
            ControlValues = new HashSet<ControlValue>();
            Payments = new HashSet<Payment>();
        }

        public long Id { get; set; }
        public decimal Price { get; set; }

        public long ProductId { get; set; }
        public Product Product { get; set; }

        public long CompanyId { get; set; }
        public Company Company { get; set; }

        public ICollection<ControlValue> ControlValues { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }
}
