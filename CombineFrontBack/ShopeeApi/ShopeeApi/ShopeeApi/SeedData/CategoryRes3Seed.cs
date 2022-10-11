using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopeeApi.Models;

namespace ShopeeApi.SeedData
{
    public class CategoryRes3Seed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
            (
                new Category
                {
                    CategoryId = 11,
                    CategoryName = "BÁNH MÌ",
                    CategoryTag = "banhmi",
                    RestaurantId = 3
                },

                new Category
                {
                    CategoryId = 12,
                    CategoryName = "BÚN",
                    CategoryTag = "bun",
                    RestaurantId = 3
                },

                new Category
                {
                    CategoryId = 13,
                    CategoryName = "MÓN THÊM",
                    CategoryTag = "monthem",
                    RestaurantId = 3
                },

                new Category
                {
                    CategoryId = 14,
                    CategoryName = "THỨC UỐNG",
                    CategoryTag = "thucuong",
                    RestaurantId = 3
                }
            );
        }
    }
}
