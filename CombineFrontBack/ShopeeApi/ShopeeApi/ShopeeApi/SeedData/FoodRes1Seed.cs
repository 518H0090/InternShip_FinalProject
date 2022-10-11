using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopeeApi.Models;

namespace ShopeeApi.SeedData
{
    public class FoodRes1Seed : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData
            (
                new Food
                {
                    FoodId = 1,
                    FoodImageUrl = "./ImageForSeedData/Food/Restaurant1/food1.jpeg",
                    FoodTitle = "Pate bơ béo (400gram)",
                    FoodDescription = "Hộp đã được nâng cấp lên từ 300->400 gram vẫn nguyên giá cux",
                    FoodPrice = 85000,
                    RestaurantId = 1
                },

                 new Food
                 {
                     FoodId = 2,
                     FoodImageUrl = "./ImageForSeedData/Food/Restaurant1/food2.jpeg",
                     FoodTitle = "Pate sate (400gram)",
                     FoodDescription = "Hộp đã được nâng cấp từ 300->400 gram với giá giữ nguyên",
                     FoodPrice = 85000,
                     RestaurantId = 1
                 },

                 new Food
                 {
                     FoodId = 3,
                     FoodImageUrl = "./ImageForSeedData/Food/Restaurant1/food3.jpeg",
                     FoodTitle = "Muối nguyễn thần thánh",
                     FoodDescription = "1 hủ/ 150gr",
                     FoodPrice = 44000,
                     RestaurantId = 1
                 }
            );
        }
    }
}
