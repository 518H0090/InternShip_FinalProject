using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopeeApi.Models;

namespace ShopeeApi.SeedData
{
    public class FoodRes2Seed : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData
            (
                 new Food
                 {
                     FoodId = 4,
                     FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food4.jpeg",
                     FoodTitle = "Trà sữa trân châu hoàng kim",
                     FoodDescription = "",
                     FoodPrice = 50000,
                     FoodPriceLess = 30000,
                     RestaurantId = 2
                 },

                 new Food
                 {
                     FoodId = 5,
                     FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food5.jpeg",
                     FoodTitle = "Trà sữa Hongkong Royal",
                     FoodDescription = "",
                     FoodPrice = 45000,
                     FoodPriceLess = 27000,
                     RestaurantId = 2
                 },

                 new Food
                 {
                     FoodId = 6,
                     FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food6.jpeg",
                     FoodTitle = "Trà sữa lúa mạch",
                     FoodDescription = "",
                     FoodPrice = 45000,
                     FoodPriceLess = 27000,
                     RestaurantId = 2
                 },

                  new Food
                  {
                      FoodId = 7,
                      FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food7.jpeg",
                      FoodTitle = "Hồng trà sữa",
                      FoodDescription = "",
                      FoodPrice = 45000,
                      FoodPriceLess = 27000,
                      RestaurantId = 2
                  },

                  new Food
                  {
                      FoodId = 8,
                      FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food7.jpeg",
                      FoodTitle = "Trà sữa hoa nhài",
                      FoodDescription = "",
                      FoodPrice = 45000,
                      FoodPriceLess = 27000,
                      RestaurantId = 2
                  },

                  new Food
                  {
                      FoodId = 9,
                      FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food7.jpeg",
                      FoodTitle = "Trà sữa olong kim phượng",
                      FoodDescription = "",
                      FoodPrice = 45000,
                      FoodPriceLess = 27000,
                      RestaurantId = 2
                  },

                  new Food
                  {
                      FoodId = 10,
                      FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food7.jpeg",
                      FoodTitle = "Trà sữa olong bạch đào",
                      FoodDescription = "",
                      FoodPrice = 45000,
                      FoodPriceLess = 27000,
                      RestaurantId = 2
                  },

                  new Food
                  {
                      FoodId = 11,
                      FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food11.png",
                      FoodTitle = "Sữa tươi trân châu hoàng kim",
                      FoodDescription = "không chọn được mức đá",
                      FoodPrice = 50000,
                      FoodPriceLess = 30000,
                      RestaurantId = 2
                  },

                   new Food
                   {
                       FoodId = 12,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food11.png",
                       FoodTitle = "Đường Đen Sầu Riêng",
                       FoodDescription = "",
                       FoodPrice = 50000,
                       FoodPriceLess = 30000,
                       RestaurantId = 2
                   },

                    new Food
                    {
                        FoodId = 13,
                        FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food13.jpeg",
                        FoodTitle = "Sữa tươi trân châu đường đen",
                        FoodDescription = "không thể để đá riêng",
                        FoodPrice = 50000,
                        FoodPriceLess = 30000,
                        RestaurantId = 2
                    },

                    new Food
                    {
                        FoodId = 14,
                        FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food14.jpeg",
                        FoodTitle = "Trà sữa trân châu đường đen",
                        FoodDescription = "",
                        FoodPrice = 50000,
                        FoodPriceLess = 30000,
                        RestaurantId = 2
                    },

                    new Food
                    {
                        FoodId = 15,
                        FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food15.jpeg",
                        FoodTitle = "Matcha đường đen",
                        FoodDescription = "Size M",
                        FoodPrice = 57000,
                        FoodPriceLess = 34200,
                        RestaurantId = 2
                    },

                     new Food
                     {
                         FoodId = 16,
                         FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food16.jpeg",
                         FoodTitle = "Trà táo xanh kiwi",
                         FoodDescription = "Thơm ngon",
                         FoodPrice = 65000,
                         FoodPriceLess = 39000,
                         RestaurantId = 2
                     },

                      new Food
                      {
                          FoodId = 17,
                          FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food17.jpeg",
                          FoodTitle = "Matcha đường đen kem cheese",
                          FoodDescription = "SizeM",
                          FoodPrice = 69000,
                          FoodPriceLess = 41400,
                          RestaurantId = 2
                      },

                       new Food
                       {
                           FoodId = 18,
                           FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food11.png",
                           FoodTitle = "Trà sữa khoai môn đường đen",
                           FoodDescription = "",
                           FoodPrice = 55000,
                           FoodPriceLess = 33000,
                           RestaurantId = 2
                       },

                        new Food
                        {
                            FoodId = 19,
                            FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food19.jpeg",
                            FoodTitle = "Trà lúa mạch kem cheese",
                            FoodDescription = "",
                            FoodPrice = 54000,
                            FoodPriceLess = 32400,
                            RestaurantId = 2
                        },

                        new Food
                        {
                            FoodId = 20,
                            FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food20.jpeg",
                            FoodTitle = "Hồng trà Royal kem cheese",
                            FoodDescription = "",
                            FoodPrice = 54000,
                            FoodPriceLess = 32400,
                            RestaurantId = 2
                        },

                        new Food
                        {
                            FoodId = 21,
                            FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food21.jpeg",
                            FoodTitle = "Trà sương mù London kem cheese",
                            FoodDescription = "",
                            FoodPrice = 57000,
                            FoodPriceLess = 34200,
                            RestaurantId = 2
                        },

                        new Food
                        {
                            FoodId = 22,
                            FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food22.jpeg",
                            FoodTitle = "Trà xanh Golden kem cheese",
                            FoodDescription = "",
                            FoodPrice = 54000,
                            FoodPriceLess = 34200,
                            RestaurantId = 2
                        },

                        new Food
                        {
                            FoodId = 23,
                            FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food23.jpeg",
                            FoodTitle = "Trà ô long bạch đào kem cheese",
                            FoodDescription = "",
                            FoodPrice = 54000,
                            FoodPriceLess = 32400,
                            RestaurantId = 2
                        },

                        new Food
                        {
                            FoodId = 24,
                            FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food24.jpeg",
                            FoodTitle = "Trà bách hoa kem cheese",
                            FoodDescription = "",
                            FoodPrice = 54000,
                            FoodPriceLess = 32400,
                            RestaurantId = 2
                        },

                        new Food
                        {
                            FoodId = 25,
                            FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food25.jpeg",
                            FoodTitle = "Trà ô long mộc hoa kem cheese",
                            FoodDescription = "",
                            FoodPrice = 54000,
                            FoodPriceLess = 32400,
                            RestaurantId = 2
                        },

                        new Food
                        {
                            FoodId = 26,
                            FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food25.jpeg",
                            FoodTitle = "Trà oolong Kim Phượng kem cheese",
                            FoodDescription = "",
                            FoodPrice = 54000,
                            FoodPriceLess = 32400,
                            RestaurantId = 2
                        },

                        new Food
                        {
                            FoodId = 27,
                            FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food27.jpeg",
                            FoodTitle = "Trà sữa oreo cake cream",
                            FoodDescription = "",
                            FoodPrice = 59000,
                            FoodPriceLess = 35400,
                            RestaurantId = 2
                        },

                         new Food
                         {
                             FoodId = 28,
                             FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food28.jpeg",
                             FoodTitle = "Trà sữa trân châu ngọc trai trắng",
                             FoodDescription = "",
                             FoodPrice = 55000,
                             FoodPriceLess = 33000,
                             RestaurantId = 2
                         },

                         new Food
                         {
                             FoodId = 29,
                             FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food29.jpeg",
                             FoodTitle = "Trà sữa trân châu ngọc trai đen",
                             FoodDescription = "",
                             FoodPrice = 55000,
                             FoodPriceLess = 33000,
                             RestaurantId = 2
                         },

                          new Food
                          {
                              FoodId = 30,
                              FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food30.jpeg",
                              FoodTitle = "Trà hoa quả Royaltea đặc biệt",
                              FoodDescription = "",
                              FoodPrice = 68000,
                              FoodPriceLess = 40800,
                              RestaurantId = 2
                          },

                           new Food
                           {
                               FoodId = 31,
                               FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food31.jpeg",
                               FoodTitle = "Trà xanh cam bưởi dâu tây",
                               FoodDescription = "",
                               FoodPrice = 65000,
                               FoodPriceLess = 39000,
                               RestaurantId = 2
                           },

                           new Food
                           {
                               FoodId = 32,
                               FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food32.jpeg",
                               FoodTitle = "Trà xanh cam bưởi nhiệt đới",
                               FoodDescription = "",
                               FoodPrice = 65000,
                               FoodPriceLess = 39000,
                               RestaurantId = 2
                           },

                            new Food
                            {
                                FoodId = 33,
                                FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food33.jpeg",
                                FoodTitle = "Socola kem cheese",
                                FoodDescription = "",
                                FoodPrice = 58000,
                                FoodPriceLess = 34800,
                                RestaurantId = 2
                            },

                             new Food
                             {
                                 FoodId = 34,
                                 FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food34.jpeg",
                                 FoodTitle = "Scola cake cream",
                                 FoodDescription = "",
                                 FoodPrice = 55000,
                                 FoodPriceLess = 33000,
                                 RestaurantId = 2
                             },

                              new Food
                              {
                                  FoodId = 35,
                                  FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food35.jpeg",
                                  FoodTitle = "Smoothie xoài kem cheese",
                                  FoodDescription = "",
                                  FoodPrice = 67000,
                                  FoodPriceLess = 40200,
                                  RestaurantId = 2
                              },

                              new Food
                              {
                                  FoodId = 36,
                                  FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food36.jpeg",
                                  FoodTitle = "Smoothie dưa hấu kem cheese",
                                  FoodDescription = "",
                                  FoodPrice = 67000,
                                  FoodPriceLess = 40200,
                                  RestaurantId = 2
                              },

                              new Food
                              {
                                  FoodId = 37,
                                  FoodImageUrl = "./ImageForSeedData/Food/Restaurant2/food37.jpeg",
                                  FoodTitle = "Smoothie ruby",
                                  FoodDescription = "",
                                  FoodPrice = 67000,
                                  FoodPriceLess = 40200,
                                  RestaurantId = 2
                              }

            );
        }
    }
}