using Insurance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Insurance.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class ControlEntityTypeConfiguration : IEntityTypeConfiguration<Control>
    {
        public void Configure(EntityTypeBuilder<Control> builder)
        {
            builder.HasKey(c => c.Id);
        }
    }
}
