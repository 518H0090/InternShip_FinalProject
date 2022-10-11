using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopeeApi.Models;

namespace ShopeeApi.SeedData
{
    public class CategoryRes1Seed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
            (
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "MENU",
                    CategoryTag = "menu",
                    RestaurantId = 1
                }
            );
        }
    }
}
