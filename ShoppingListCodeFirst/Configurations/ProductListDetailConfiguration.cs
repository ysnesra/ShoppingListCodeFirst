using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingListCodeFirst.Models;

namespace ShoppingListCodeFirst.Configurations
{
    public class ProductListDetailConfiguration : IEntityTypeConfiguration<ProductListDetail>
    {
        public void Configure(EntityTypeBuilder<ProductListDetail> builder)
        {
            builder.HasKey(a => new { a.ProductId, a.ProductListId });
            builder.HasOne(a => a.Product)
                .WithMany(a => a.ProductListDetails)
                .HasForeignKey(a => a.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.ProductList)
              .WithMany(a => a.ProductListDetails)
              .HasForeignKey(a => a.ProductListId)
              .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
