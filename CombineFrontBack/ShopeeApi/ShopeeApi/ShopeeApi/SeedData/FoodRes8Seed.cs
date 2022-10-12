using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopeeApi.Models;

namespace ShopeeApi.SeedData
{
    public class FoodRes8Seed : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData
            (
                new Food
                {
                    FoodId = 128,
                    FoodImageUrl = "./ImageForSeedData/Food/Restaurant8/food128.jpeg",
                    FoodTitle = "Combo 2 Cơm thập cẩm chay",
                    FoodDescription = "",
                    FoodPrice = 54000,
                    RestaurantId = 8
                },

                 new Food
                 {
                     FoodId = 129,
                     FoodImageUrl = "./ImageForSeedData/Food/Restaurant8/food129.jpeg",
                     FoodTitle = "Cơm thập cẩm chay",
                     FoodDescription = "",
                     FoodPrice = 29000,
                     RestaurantId = 8
                 },

                 new Food
                 {
                     FoodId = 130,
                     FoodImageUrl = "./ImageForSeedData/Food/Restaurant8/food130.jpeg",
                     FoodTitle = "Cơm chiên Dương Châu chay",
                     FoodDescription = "",
                     FoodPrice = 44000,
                     RestaurantId = 8
                 },

                 new Food
                 {
                     FoodId = 131,
                     FoodImageUrl = "./ImageForSeedData/Food/Restaurant8/food131.jpeg",
                     FoodTitle = "Bún Huế chay",
                     FoodDescription = "",
                     FoodPrice = 29000,
                     RestaurantId = 8
                 },

                 new Food
                 {
                     FoodId = 132,
                     FoodImageUrl = "./ImageForSeedData/Food/Restaurant8/food132.jpeg",
                     FoodTitle = "Hủ tiếu Sa Đéc chay",
                     FoodDescription = "",
                     FoodPrice = 29000,
                     RestaurantId = 8
                 },

                  new Food
                  {
                      FoodId = 133,
                      FoodImageUrl = "./ImageForSeedData/Food/Restaurant8/food133.jpeg",
                      FoodTitle = "Lẩu Thái chay",
                      FoodDescription = "",
                      FoodPrice = 160000,
                      RestaurantId = 8
                  },

                   new Food
                   {
                       FoodId = 134,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant8/food134.jpeg",
                       FoodTitle = "Lẩu nấm chay",
                       FoodDescription = "",
                       FoodPrice = 160000,
                       RestaurantId = 8
                   }
            );
        }
    }
}