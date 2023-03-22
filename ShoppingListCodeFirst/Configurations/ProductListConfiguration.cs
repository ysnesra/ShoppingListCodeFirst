using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingListCodeFirst.Models;

namespace ShoppingListCodeFirst.Configurations
{
    public class ProductListConfiguration : IEntityTypeConfiguration<ProductList>
    {
        public void Configure(EntityTypeBuilder<ProductList> builder)
        {
            builder.HasOne(a => a.User)
                .WithMany(a => a.ProductLists)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
