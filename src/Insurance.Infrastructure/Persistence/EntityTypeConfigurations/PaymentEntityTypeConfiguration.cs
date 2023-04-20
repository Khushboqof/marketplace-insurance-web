using Insurance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Insurance.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class PaymentEntityTypeConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(o => o.User)
                .WithMany(o => o.Payments)
                .HasForeignKey(o => o.UserId);

            builder.HasOne(o => o.ProductInCompany)
                .WithMany(o => o.Payments)
                .HasForeignKey(o => o.ProductInCompanyId);
        }
    }
}
