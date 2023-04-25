using Insurance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Insurance.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class ProductInCompanyEntityTypeConfiguration : IEntityTypeConfiguration<ProductInCompany>
    {
        public void Configure(EntityTypeBuilder<ProductInCompany> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(o => o.Product)
                .WithMany(o => o.ProductInCompanies)
                .HasForeignKey(o => o.ProductId);
        }
    }
}
