namespace Insurance.Domain.Entities
{
    public class Company
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; } 
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; } 
    }
}
