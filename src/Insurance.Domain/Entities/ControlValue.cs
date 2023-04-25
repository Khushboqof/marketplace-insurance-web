namespace Insurance.Domain.Entities
{
    public class ControlValue
    {
        public long Id { get; set; }
        public string Value { get; set; } = string.Empty;

        public long ControlId { get; set; }
        public Control Control { get; set; } = null!;

        public long ProductInCompanyId { get; set; }
        public ProductInCompany ProductInCompany { get; set; } = null!;
    }
}
