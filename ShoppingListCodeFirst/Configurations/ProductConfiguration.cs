using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingListCodeFirst.Models;

namespace ShoppingListCodeFirst.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //HasOne: bir ürünün bir Categorisi olduğunu belirtir
            //WithMany: bir Categorinin de birden çok ürünü var
            //HasForeignKey: Product tablosunda CategoryId foreignKey
            //IsRequired: Bütün ürünlerin kategorisi olmak zorunda dersek kullanırız
            builder.HasOne(a => a.Category)
                .WithMany(a => a.Products)
                .HasForeignKey(a => a.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(a => a.ProductName).HasMaxLength(50);
        }

    }
}
