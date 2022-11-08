using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopeeApi.Models;

namespace ShopeeApi.SeedData
{
    public class CategoryRes2Seed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
            (
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "FREESHIP XTRA SIÊU ƯU ĐÃI - GIẢM 50%",
                    CategoryTag = "freeship50%",
                    RestaurantId = 2
                },

                new Category
                {
                    CategoryId = 3,
                    CategoryName = "NOWFOOD DAY",
                    CategoryTag = "nowfoodday",
                    RestaurantId = 2
                },

                new Category
                {
                    CategoryId = 4,
                    CategoryName = "NEW",
                    CategoryTag = "new",
                    RestaurantId = 2
                },

                new Category
                {
                    CategoryId = 5,
                    CategoryName = "ROYAL BLACK TIGER",
                    CategoryTag = "royalblacktiger",
                    RestaurantId = 2
                },

                 new Category
                 {
                     CategoryId = 6,
                     CategoryName = "ROYAL CHEESE TEA",
                     CategoryTag = "royalcheesetea",
                     RestaurantId = 2
                 },

                new Category
                {
                    CategoryId = 7,
                    CategoryName = "MILK TEA",
                    CategoryTag = "milktea",
                    RestaurantId = 2
                },

                new Category
                {
                    CategoryId = 8,
                    CategoryName = "FRESH FRUIT TEA",
                    CategoryTag = "freshfruittea",
                    RestaurantId = 2
                },

                new Category
                {
                    CategoryId = 9,
                    CategoryName = "MATCHA & CHOCOLATE",
                    CategoryTag = "matchachocolate",
                    RestaurantId = 2
                },

                 new Category
                 {
                     CategoryId = 10,
                     CategoryName = "SMOOTHIE CHEESE",
                     CategoryTag = "smoothiecheese",
                     RestaurantId = 2
                 }
            );
        }
    }
}