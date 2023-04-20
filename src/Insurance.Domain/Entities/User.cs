namespace Insurance.Domain.Entities
{
    public class User
    {
        public User()
        {
            Payments = new HashSet<Payment>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string PassportSeries { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Citizenship { get; set; } = string.Empty;

        public ICollection<Payment> Payments { get; set; }
    }
}
