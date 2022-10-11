using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopeeApi.Models;

namespace ShopeeApi.SeedData
{
    public class CategoryRes9Seed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
            (
                 new Category
                 {
                     CategoryId = 54,
                     CategoryName = "BANH1 BISCOTTI",
                     CategoryTag = "banhbiscotti",
                     RestaurantId = 9
                 }
            );
        }
    }
}
