using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopeeApi.Models;

namespace ShopeeApi.SeedData
{
    public class CategoryRes8Seed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
            (
                new Category
                {
                    CategoryId = 50,
                    CategoryName = "COMBO",
                    CategoryTag = "combo",
                    RestaurantId = 8
                },

                new Category
                {
                    CategoryId = 51,
                    CategoryName = "MÓN CƠM",
                    CategoryTag = "moncom",
                    RestaurantId = 8
                },

                new Category
                {
                    CategoryId = 52,
                    CategoryName = "MÓN SỢI",
                    CategoryTag = "monsoi",
                    RestaurantId = 8
                },

                new Category
                {
                    CategoryId = 53,
                    CategoryName = "MÓN LẨU",
                    CategoryTag = "monlau",
                    RestaurantId = 8
                }
            );
        }
    }
}
