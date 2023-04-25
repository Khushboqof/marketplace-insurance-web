using Insurance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Insurance.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class ControlValueEntityTypeConfiguration : IEntityTypeConfiguration<ControlValue>
    {
        public void Configure(EntityTypeBuilder<ControlValue> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(o => o.Control)
                .WithMany(o => o.Values)
                .HasForeignKey(o => o.ControlId);

            builder.HasOne(o => o.ProductInCompany)
                .WithMany(o => o.ControlValues)
                .HasForeignKey(o => o.ProductInCompanyId);
        }
    }
}
