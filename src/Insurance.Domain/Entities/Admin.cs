namespace Insurance.Domain.Entities
{
    public class Admin
    {
        public long Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
