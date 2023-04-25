using Insurance.Application.Abstractions;
using Insurance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Insurance.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Control> Controls { get; set; }
        public DbSet<ControlValue> ControlValues { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInCompany> ProductInCompanies { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
