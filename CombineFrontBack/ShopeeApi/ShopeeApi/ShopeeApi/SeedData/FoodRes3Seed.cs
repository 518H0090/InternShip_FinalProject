using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopeeApi.Models;

namespace ShopeeApi.SeedData
{
    public class FoodRes3Seed : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData
            (
                 new Food
                 {
                     FoodId = 38,
                     FoodImageUrl = "./ImageForSeedData/Food/Restaurant3/food38.jpeg",
                     FoodTitle = "Bánh mì thịt nướng",
                     FoodDescription = "",
                     FoodPrice = 26000,
                     RestaurantId = 3
                 },

                  new Food
                  {
                      FoodId = 39,
                      FoodImageUrl = "./ImageForSeedData/Food/Restaurant3/food39.jpeg",
                      FoodTitle = "Bánh mì thịt nướng đặc biệt",
                      FoodDescription = "",
                      FoodPrice = 32000,
                      RestaurantId = 3
                  },

                  new Food
                  {
                      FoodId = 40,
                      FoodImageUrl = "./ImageForSeedData/Food/Restaurant3/food40.jpeg",
                      FoodTitle = "Bún thịt nướng đặc biệt",
                      FoodDescription = "",
                      FoodPrice = 47000,
                      RestaurantId = 3
                  },

                   new Food
                   {
                       FoodId = 41,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant3/food41.jpeg",
                       FoodTitle = "Bún thịt nướng",
                       FoodDescription = "",
                       FoodPrice = 33000,
                       RestaurantId = 3
                   },

                   new Food
                   {
                       FoodId = 42,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant3/food42.jpeg",
                       FoodTitle = "Bún nem nướng",
                       FoodDescription = "",
                       FoodPrice = 33000,
                       RestaurantId = 3
                   },

                   new Food
                   {
                       FoodId = 43,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant3/food43.jpeg",
                       FoodTitle = "Bún Chả giò",
                       FoodDescription = "",
                       FoodPrice = 30000,
                       RestaurantId = 3
                   },

                    new Food
                    {
                        FoodId = 44,
                        FoodImageUrl = "./ImageForSeedData/Food/Restaurant3/food44.jpeg",
                        FoodTitle = "Chả giò",
                        FoodDescription = "Cái",
                        FoodPrice = 6000,
                        RestaurantId = 3
                    },

                    new Food
                    {
                        FoodId = 45,
                        FoodImageUrl = "./ImageForSeedData/Food/Restaurant3/food45.jpeg",
                        FoodTitle = "Thịt xiên",
                        FoodDescription = "Xiên",
                        FoodPrice = 18000,
                        RestaurantId = 3
                    },

                    new Food
                    {
                        FoodId = 46,
                        FoodImageUrl = "./ImageForSeedData/Food/Restaurant3/food46.jpeg",
                        FoodTitle = "Thịt viên",
                        FoodDescription = "Viên",
                        FoodPrice = 6000,
                        RestaurantId = 3
                    },

                    new Food
                    {
                        FoodId = 47,
                        FoodImageUrl = "./ImageForSeedData/Food/Restaurant3/food47.jpeg",
                        FoodTitle = "Nem nướng",
                        FoodDescription = "",
                        FoodPrice = 12000,
                        RestaurantId = 3
                    },

                    new Food
                    {
                        FoodId = 48,
                        FoodImageUrl = "./ImageForSeedData/Food/Restaurant3/food48.jpeg",
                        FoodTitle = "Bún thêm",
                        FoodDescription = "",
                        FoodPrice = 3000,
                        RestaurantId = 3
                    },

                     new Food
                     {
                         FoodId = 49,
                         FoodImageUrl = "./ImageForSeedData/Food/Restaurant3/food49.jpeg",
                         FoodTitle = "Rau thêm",
                         FoodDescription = "",
                         FoodPrice = 3000,
                         RestaurantId = 3
                     },

                      new Food
                      {
                          FoodId = 50,
                          FoodImageUrl = "./ImageForSeedData/Food/Restaurant3/food50.jpeg",
                          FoodTitle = "Sâm Bí Đao Hạt Chia",
                          FoodDescription = "Thành phần: bí đao, hạt chia, thục địa, la hán quả, bông cóc ... Đường phèn",
                          FoodPrice = 15000,
                          RestaurantId = 3
                      },

                       new Food
                       {
                           FoodId = 51,
                           FoodImageUrl = "./ImageForSeedData/Food/Restaurant3/food51.jpeg",
                           FoodTitle = "Sâm Bí Đao Đường Phền",
                           FoodDescription = "Thành phần: BÍ ĐAOM THỤC ĐỊA, LA HÁN QUẢ, BÔNG CÚC ... ĐƯỜNG PHÈN",
                           FoodPrice = 12000,
                           RestaurantId = 3
                       }
            );
        }
    }
}