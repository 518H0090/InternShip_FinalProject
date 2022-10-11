using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopeeApi.Models;

namespace ShopeeApi.SeedData
{
    public class FoodRes5Seed : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData
            (
                new Food
                {
                    FoodId = 71,
                    FoodImageUrl = "./ImageForSeedData/Food/Restaurant5/food71.jpeg",
                    FoodTitle = "Combo 3",
                    FoodDescription = "Trà sữa, trân châu, bánh flan size L",
                    FoodPrice = 32000,
                    FoodPriceLess = 25600,
                    RestaurantId = 5
                },

                new Food
                {
                    FoodId = 72,
                    FoodImageUrl = "./ImageForSeedData/Food/Restaurant5/food72.jpeg",
                    FoodTitle = "Trà sữa + 1 topping (trân châu/sương sáo/thạch dẻo) size L",
                    FoodDescription = "Trà sữa + 1 topping (trân châu/sương sáo/thạch dẻo) size L",
                    FoodPrice = 24000,
                    FoodPriceLess = 19200,
                    RestaurantId = 5
                },

                 new Food
                 {
                     FoodId = 73,
                     FoodImageUrl = "./ImageForSeedData/Food/Restaurant5/food73.jpeg",
                     FoodTitle = "Dưa hấu ép",
                     FoodDescription = "",
                     FoodPrice = 34000,
                     FoodPriceLess = 27200,
                     RestaurantId = 5
                 },

                 new Food
                 {
                     FoodId = 74,
                     FoodImageUrl = "./ImageForSeedData/Food/Restaurant5/food74.jpeg",
                     FoodTitle = "Combo 4 ly Combo 5",
                     FoodDescription = "4 ly Trà sữa full topping size XL",
                     FoodPrice = 168000,
                     FoodPriceLess = 134400,
                     RestaurantId = 5
                 },

                 new Food
                 {
                     FoodId = 75,
                     FoodImageUrl = "./ImageForSeedData/Food/Restaurant5/food75.jpeg",
                     FoodTitle = "Combo 5",
                     FoodDescription = "Trà sữa full topping size XL",
                     FoodPrice = 42000,
                     FoodPriceLess = 33600,
                     RestaurantId = 5
                 },

                  new Food
                  {
                      FoodId = 76,
                      FoodImageUrl = "./ImageForSeedData/Food/Restaurant5/food76.jpeg",
                      FoodTitle = "Combo 4",
                      FoodDescription = "Trà sữa, thạch dẻo, thạch phô mai, bánh flan size L",
                      FoodPrice = 37000,
                      FoodPriceLess = 29600,
                      RestaurantId = 5
                  },

                  new Food
                  {
                      FoodId = 77,
                      FoodImageUrl = "./ImageForSeedData/Food/Restaurant5/food77.jpeg",
                      FoodTitle = "Combo 2",
                      FoodDescription = "Trà sữa, thạch dẻo, thạch phô mai size L",
                      FoodPrice = 32000,
                      FoodPriceLess = 25600,
                      RestaurantId = 5
                  },

                  new Food
                  {
                      FoodId = 78,
                      FoodImageUrl = "./ImageForSeedData/Food/Restaurant5/food78.jpeg",
                      FoodTitle = "Trà đào cam sả",
                      FoodDescription = "",
                      FoodPrice = 35000,
                      FoodPriceLess = 28000,
                      RestaurantId = 5
                  },

                   new Food
                   {
                       FoodId = 79,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant5/food79.jpeg",
                       FoodTitle = "Trà đào dầm",
                       FoodDescription = "",
                       FoodPrice = 22000,
                       FoodPriceLess = 17600,
                       RestaurantId = 5
                   },

                    new Food
                    {
                        FoodId = 80,
                        FoodImageUrl = "./ImageForSeedData/Food/Restaurant5/food80.jpeg",
                        FoodTitle = "Lục trà bạc hà",
                        FoodDescription = "",
                        FoodPrice = 21000,
                        FoodPriceLess = 16800,
                        RestaurantId = 5
                    },

                     new Food
                     {
                         FoodId = 81,
                         FoodImageUrl = "./ImageForSeedData/Food/Restaurant5/food81.jpeg",
                         FoodTitle = "Trà Cam Nhài",
                         FoodDescription = "",
                         FoodPrice = 34000,
                         FoodPriceLess = 27200,
                         RestaurantId = 5
                     },

                     new Food
                     {
                         FoodId = 82,
                         FoodImageUrl = "./ImageForSeedData/Food/Restaurant5/food82.jpeg",
                         FoodTitle = "Sữa tươi trân châu đường đen",
                         FoodDescription = "",
                         FoodPrice = 25000,
                         FoodPriceLess = 20000,
                         RestaurantId = 5
                     },

                     new Food
                     {
                         FoodId = 83,
                         FoodImageUrl = "./ImageForSeedData/Food/Restaurant5/food83.jpeg",
                         FoodTitle = "Sữa tươi matcha trân châu đường đen",
                         FoodDescription = "",
                         FoodPrice = 30000,
                         FoodPriceLess = 24000,
                         RestaurantId = 5
                     },

                      new Food
                      {
                          FoodId = 84,
                          FoodImageUrl = "./ImageForSeedData/Food/Restaurant5/food84.jpeg",
                          FoodTitle = "Sữa tươi đường đen sương sáo",
                          FoodDescription = "",
                          FoodPrice = 25000,
                          FoodPriceLess = 20000,
                          RestaurantId = 5
                      },

                      new Food
                      {
                          FoodId = 85,
                          FoodImageUrl = "./ImageForSeedData/Food/Restaurant5/food85.jpeg",
                          FoodTitle = "Trà sữa",
                          FoodDescription = "",
                          FoodPrice = 21000,
                          FoodPriceLess = 16800,
                          RestaurantId = 5
                      },

                       new Food
                       {
                           FoodId = 86,
                           FoodImageUrl = "./ImageForSeedData/Food/Restaurant5/food86.jpeg",
                           FoodTitle = "Trà sữa socola",
                           FoodDescription = "",
                           FoodPrice = 27000,
                           FoodPriceLess = 21600,
                           RestaurantId = 5
                       },

                        new Food
                        {
                            FoodId = 87,
                            FoodImageUrl = "./ImageForSeedData/Food/Restaurant5/food87.jpeg",
                            FoodTitle = "Trà sữa hoa đậu biếc",
                            FoodDescription = "",
                            FoodPrice = 22000,
                            FoodPriceLess = 17600,
                            RestaurantId = 5
                        },

                        new Food
                        {
                            FoodId = 88,
                            FoodImageUrl = "./ImageForSeedData/Food/Restaurant5/food88.jpeg",
                            FoodTitle = "Thơm ép",
                            FoodDescription = "",
                            FoodPrice = 32000,
                            FoodPriceLess = 25600,
                            RestaurantId = 5
                        },

                        new Food
                        {
                            FoodId = 89,
                            FoodImageUrl = "./ImageForSeedData/Food/Restaurant5/food89.jpeg",
                            FoodTitle = "Ổi ép",
                            FoodDescription = "",
                            FoodPrice = 32000,
                            FoodPriceLess = 25600,
                            RestaurantId = 5
                        },

                        new Food
                        {
                            FoodId = 90,
                            FoodImageUrl = "./ImageForSeedData/Food/Restaurant5/food90.jpeg",
                            FoodTitle = "Trà sữa + Trà sữa socola",
                            FoodDescription = "",
                            FoodPrice = 48000,
                            FoodPriceLess = 38400,
                            RestaurantId = 5
                        }
            );
        }
    }
}
