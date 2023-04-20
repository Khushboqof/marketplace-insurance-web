namespace Insurance.Domain.Entities
{
    public class Control
    {
        public Control()
        {
            Values = new HashSet<ControlValue>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;

        public ICollection<ControlValue> Values { get; set; }
    }
}
