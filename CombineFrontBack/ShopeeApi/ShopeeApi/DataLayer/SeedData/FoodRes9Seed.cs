using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopeeApi.Models;

namespace ShopeeApi.SeedData
{
    public class FoodRes9Seed : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData
            (
                new Food
                {
                    FoodId = 135,
                    FoodImageUrl = "./ImageForSeedData/Food/Restaurant9/food135.jpeg",
                    FoodTitle = "Bánh Biscotti Dark Chocolate - Hộp 195gr",
                    FoodDescription = "Bánh Biscotti hạnh nhân & socola nguyên chất, dành cho những người sành ăn tạo ra một sự kết hợp ngon miệng.",
                    FoodPrice = 99000,
                    RestaurantId = 9
                },

                new Food
                {
                    FoodId = 136,
                    FoodImageUrl = "./ImageForSeedData/Food/Restaurant9/food136.jpeg",
                    FoodTitle = "Bánh Biscotti Truyền Thống - Hộp 195gr",
                    FoodDescription = "Hương vị truyền thống kết hợp hạt hạnh nhân & óc chó với một chút hương vị hạt tiểu hồi.",
                    FoodPrice = 99000,
                    RestaurantId = 9
                },

                 new Food
                 {
                     FoodId = 137,
                     FoodImageUrl = "./ImageForSeedData/Food/Restaurant9/food137.jpeg",
                     FoodTitle = "Biscotti Nam Việt Quất - Hộp 195gr",
                     FoodDescription = "Nam Việt Quất kết hợp với Hạnh Nhân và được nướng hai lần mang đến cho bạn cảm giác dai giòn ngon tuyệt đỉnh.",
                     FoodPrice = 120000,
                     RestaurantId = 9
                 }
            );
        }
    }
}