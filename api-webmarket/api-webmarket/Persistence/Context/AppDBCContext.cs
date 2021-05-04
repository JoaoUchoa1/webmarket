using api_webmarket.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api_webmarket.Persistence
{
    public class AppDBCContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Purchase> Purchases { get; set; }


        public AppDBCContext(DbContextOptions<AppDBCContext> options) : base(options){ }
        protected override void OnModelCreating(ModelBuilder builder) 
        {
            base.OnModelCreating(builder);

            builder.Entity<Company>().ToTable("Companies");
            builder.Entity<Company>().HasKey(p => p.Id);
            builder.Entity<Company>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Company>().Property(p => p.NameFantasia).IsRequired().HasMaxLength(30);
            builder.Entity<Company>().Property(p => p.RazaoSocial).IsRequired().HasMaxLength(30);
            builder.Entity<Company>().Property(p => p.Cnpj).IsRequired().HasMaxLength(18);
            builder.Entity<Company>().HasMany(p => p.Products).WithOne(p => p.Company).HasForeignKey(p => p.CompanyId);

            builder.Entity<Company>().HasData
            (
                new Company
                {
                    Id = 100,
                    NameFantasia = "Lenovo",
                    RazaoSocial = "Lenovo ltda",
                    Cnpj = "35698741256987"
                },
                new Company
                {
                    Id = 101,
                    NameFantasia = "Samsung",
                    RazaoSocial = "COREAN TEC",
                    Cnpj = "98745863215478"
                }
            );

            builder.Entity<Product>().ToTable("Products");
            builder.Entity<Product>().HasKey(p => p.Id);
            builder.Entity<Product>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Entity<Product>().Property(p => p.Description).IsRequired().HasMaxLength(50);
            builder.Entity<Product>().Property(p => p.Obs).IsRequired().HasMaxLength(50);
            builder.Entity<Product>().Property(p => p.Valor).IsRequired();
            builder.Entity<Product>().Property(p => p.Payment).IsRequired();
            builder.Entity<Product>().HasMany(p => p.Purchases).WithOne(p => p.Product).HasForeignKey(p => p.ProductId);
           
            builder.Entity<Product>().HasData
            (
                new Product
                {
                    Id = 100,
                    Name = "Ideapad 320",
                    Description = "Intel core i3, 4 gb RAm, 500 gb",
                    Obs = "220v",
                    Valor = 3500,
                    Payment = Domain.Helpers.Epayment.CreditCard,
                    CompanyId = 100
                },
                new Product
                {
                    Id = 101,
                    Name = "A20",
                    Description = "Snap Dragon, 8 cores, 40 mp",
                    Obs = "128 gb",
                    Valor = 2500,
                    Payment = Domain.Helpers.Epayment.Pix,
                    CompanyId = 101,
                    
                },
                new Product
                {
                    Id = 102,
                    Name = "Ideapad 450",
                    Description = "Intel core i5, 8 gb RAm, 1tb gb",
                    Obs = "bi volt",
                    Valor = 5000,
                    Payment = Domain.Helpers.Epayment.CreditCard,
                    CompanyId = 100,
                    
                }

            );

            builder.Entity<User>().ToTable("Users");
            builder.Entity<User>().HasKey(p => p.Id);
            builder.Entity<User>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<User>().Property(p => p.Nome).IsRequired().HasMaxLength(50);
            builder.Entity<User>().Property(p => p.Email).IsRequired().HasMaxLength(50);
            builder.Entity<User>().Property(p => p.Cpf).IsRequired().HasMaxLength(14);
            builder.Entity<User>().Property(p => p.Password).IsRequired().HasMaxLength(50);
            builder.Entity<User>().HasMany(p => p.Purchases).WithOne(p => p.User).HasForeignKey(p => p.UserId);

            builder.Entity<User>().HasData
            (
                new User
                {
                    Id = 100,
                    Nome = "Joao de Deus Uchoa",
                    Email = "joaodep2@gmail.com",
                    Cpf = "00000000000",
                    Password = "olamundo"
                }
            );

            builder.Entity<Purchase>().ToTable("Purchases");
            builder.Entity<Purchase>().HasKey(p => p.Id);
            builder.Entity<Purchase>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Purchase>().Property(p => p.TotalValue).IsRequired().HasMaxLength(50);
            builder.Entity<Purchase>().Property(p => p.data).IsRequired().HasMaxLength(50);
            
            builder.Entity<Purchase>().HasData
            (
                new Purchase
                {
                    Id = 100,
                    UserId = 100,
                    TotalValue = "500",
                    data = DateTime.Now,
                    ProductId = 100
                }
            );
        }
    }
}
