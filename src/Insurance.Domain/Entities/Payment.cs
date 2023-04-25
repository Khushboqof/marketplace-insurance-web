namespace Insurance.Domain.Entities
{
    public class Payment
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public long UserId { get; set; }
        public User User { get; set; } = null!;

        public long ProductInCompanyId { get; set; }
        public ProductInCompany ProductInCompany { get; set; } = null!;
    }
}
