using api_webmarket.Domain.Models;
using Microsoft.EntityFrameworkCore;



namespace api_webmarket.Persistence
{
    public class AppDBCContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Product> Products { get; set; }

        public AppDBCContext(DbContextOptions<AppDBCContext> options) : base(options){ }
        protected override void OnModelCreating(ModelBuilder builder) 
        {
            base.OnModelCreating(builder);

            builder.Entity<Company>().ToTable("Categories");
            builder.Entity<Company>().HasKey(p => p.Id);
            builder.Entity<Company>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Company>().Property(p => p.NameFantasia).IsRequired().HasMaxLength(30);
            builder.Entity<Company>().Property(p => p.RazaoSocial).IsRequired().HasMaxLength(30);
            builder.Entity<Company>().Property(p => p.cnpj).IsRequired().HasMaxLength(18);
            builder.Entity<Company>().HasMany(p => p.Products).WithOne(p => p.Company).HasForeignKey(p => p.CompanyId);

            builder.Entity<Company>().HasData(
                new Company { Id = 100, NameFantasia = "Lenovo"},
                new Company { Id = 101, NameFantasia = "Samsung" }
            );

            builder.Entity<Product>().ToTable("Products");
            builder.Entity<Product>().HasKey(p => p.Id);
            builder.Entity<Product>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Entity<Product>().Property(p => p.Description).IsRequired().HasMaxLength(50);
            builder.Entity<Product>().Property(p => p.Obs).IsRequired().HasMaxLength(50);
            builder.Entity<Product>().Property(p => p.Valor).IsRequired();
            builder.Entity<Product>().Property(p => p.Payment).IsRequired();
        }
    }
}
