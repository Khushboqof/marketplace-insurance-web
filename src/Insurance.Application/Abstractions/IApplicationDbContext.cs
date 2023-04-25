using Insurance.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Insurance.Application.Abstractions
{
    public interface IApplicationDbContext
    {
        DbSet<Admin> Admins { get; set; }
        DbSet<Company> Companys { get; set; }
        DbSet<Control> Controls { get; set; }
        DbSet<ControlValue> ControlValues { get; set; }
        DbSet<Payment> Payment { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductInCompany> ProductInCompanies { get; set; }
        DbSet<User> Users { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
