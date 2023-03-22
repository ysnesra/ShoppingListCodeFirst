using Microsoft.EntityFrameworkCore;
using ShoppingListCodeFirst.Configurations;
using System.Reflection;

namespace ShoppingListCodeFirst.Models
{
    public class ShoppingListCodeFirstContext : DbContext
    {
        //Oluşturduğumuz entity classlarını DbSet ile property olarak gösterip tablolarımızı tanımlıyoruz  
        //Product entitiysinden -> Products tablosu oluşur
        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<ProductList> ProductLists { get; set; }
        public DbSet<ProductListDetail> ProductListDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Note>  Notes { get; set; }

        //onConfiguring metotu; Context classımızla ilgili temel ayarları yapmamızı sağlar
        //hangi veritabanı sunucusuna bağlanacağını onConfiguring içine yazarız
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ShoppingListCodeFirstDb;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
