using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopeeApi.Models;

namespace ShopeeApi.SeedData
{
    public class FoodRes6Seed : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData
            (
                new Food
                {
                    FoodId = 91,
                    FoodImageUrl = "./ImageForSeedData/Food/Restaurant6/food91.jpeg",
                    FoodTitle = "Mì khô gà chiên giòn mắm tỏi",
                    FoodDescription = "2 vắt mì + đùi gà góc tư mắm tỏi + cải Tặng kèm 1 ly Trà La Hán Quả",
                    FoodPrice = 87000,
                    FoodPriceLess = 78300,
                    RestaurantId = 6
                },

                new Food
                {
                    FoodId = 92,
                    FoodImageUrl = "./ImageForSeedData/Food/Restaurant6/food92.jpeg",
                    FoodTitle = "Mì khô thập cẩm Hong Kong",
                    FoodDescription = "2 vắt mì + tôm + xá xíu + gà xé + 2 cá viên hấp + trứng bắc thảo + sate tôm X.O Tặng kèm 1 ly Trà La Hán Quar",
                    FoodPrice = 97000,
                    FoodPriceLess = 87300,
                    RestaurantId = 6
                },

                new Food
                {
                    FoodId = 93,
                    FoodImageUrl = "./ImageForSeedData/Food/Restaurant6/food93.jpeg",
                    FoodTitle = "Mì hoành thánh khô gà góc tư mắm giòn",
                    FoodDescription = "2 vắt mì + 4 hoành thánh chiên + 1 đùi gà góc tư mắm tỏi + cải Tặng kèm 1 ly Trà La Hán Quả",
                    FoodPrice = 97000,
                    FoodPriceLess = 87300,
                    RestaurantId = 6
                },

                 new Food
                 {
                     FoodId = 94,
                     FoodImageUrl = "./ImageForSeedData/Food/Restaurant6/food94.jpg",
                     FoodTitle = "Hoành thánh giấm đen",
                     FoodDescription = "8 viên hoành thánh luộc + Sốt giấm đen + Sate tôm X.O + cải",
                     FoodPrice = 69000,
                     FoodPriceLess = 62100,
                     RestaurantId = 6
                 },

                  new Food
                  {
                      FoodId = 95,
                      FoodImageUrl = "./ImageForSeedData/Food/Restaurant6/food95.jpeg",
                      FoodTitle = "Sủi cảo khô sốt X.O",
                      FoodDescription = "6 viên sủi cảo + sốt tương sate tôm X.O + cải Tặng kèm 1 ly Trà La Hán Quả",
                      FoodPrice = 69000,
                      FoodPriceLess = 62100,
                      RestaurantId = 6
                  },

                   new Food
                   {
                       FoodId = 96,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant6/food96.jpeg",
                       FoodTitle = "Hoành sủi khô",
                       FoodDescription = "3 Sủi cảo + 5 Hoành thánh + Sốt tương sate X.O + cải Tặng kèm 1 ly Trà La Hán Quar",
                       FoodPrice = 69000,
                       FoodPriceLess = 62100,
                       RestaurantId = 6
                   },

                   new Food
                   {
                       FoodId = 97,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant6/food97.jpeg",
                       FoodTitle = "Combo thập cẩm chiên lớn",
                       FoodDescription = "6 hoành thánh chiên + 6 cá viên mắm tỏi + bắc thảo + trứng gà Tặng kèm 1 ly Trà La Hán Quả",
                       FoodPrice = 69000,
                       FoodPriceLess = 62100,
                       RestaurantId = 6
                   },

                   new Food
                   {
                       FoodId = 98,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant6/food98.jpeg",
                       FoodTitle = "Hoành thánh nước xá xíu",
                       FoodDescription = "8 viên hoành thánh nước + xá xíu + cải",
                       FoodPrice = 59000,
                       FoodPriceLess = 53100,
                       RestaurantId = 6
                   },

                     new Food
                     {
                         FoodId = 99,
                         FoodImageUrl = "./ImageForSeedData/Food/Restaurant6/food99.jpeg",
                         FoodTitle = "Mì khô xá xíu",
                         FoodDescription = "2 vắt mì + xá xíu + cải Tặng kèm 1 ly Trà La Hán Quả",
                         FoodPrice = 59000,
                         FoodPriceLess = 53100,
                         RestaurantId = 6
                     },

                      new Food
                      {
                          FoodId = 100,
                          FoodImageUrl = "./ImageForSeedData/Food/Restaurant6/food100.jpeg",
                          FoodTitle = "Mì khô cá hoành chiên mắm",
                          FoodDescription = "2 vắt mì + 2 hoành thánh chiên + 6 viên cá chiên mắm + cải Tặng kèm 1 Ly Trà La Hán Quả",
                          FoodPrice = 59000,
                          FoodPriceLess = 53100,
                          RestaurantId = 6
                      },

                      new Food
                      {
                          FoodId = 101,
                          FoodImageUrl = "./ImageForSeedData/Food/Restaurant6/food101.jpeg",
                          FoodTitle = "Mì khô hoành thánh chiên (Ko kèm chén súp)",
                          FoodDescription = "2 vắt mì trộn khô + 4 viên hoành thánh chiên + Cải Tặng kèm 1 ly Trà La Hán Quả",
                          FoodPrice = 59000,
                          FoodPriceLess = 53100,
                          RestaurantId = 6
                      },

                      new Food
                      {
                          FoodId = 102,
                          FoodImageUrl = "./ImageForSeedData/Food/Restaurant6/food102.jpeg",
                          FoodTitle = "Mì khô gà xé",
                          FoodDescription = "2 vắt mì + gà luộc xé + cải Tặng kèm 1 Ly Trà La Hán Quả",
                          FoodPrice = 59000,
                          FoodPriceLess = 53100,
                          RestaurantId = 6
                      },

                      new Food
                      {
                          FoodId = 103,
                          FoodImageUrl = "./ImageForSeedData/Food/Restaurant6/food103.jpeg",
                          FoodTitle = "Mì hoành thánh nước",
                          FoodDescription = "2 vắt mì + 5 hoành thánh luộc + cải + Súp",
                          FoodPrice = 59000,
                          FoodPriceLess = 53100,
                          RestaurantId = 6
                      },

                      new Food
                      {
                          FoodId = 104,
                          FoodImageUrl = "./ImageForSeedData/Food/Restaurant6/food104.jpeg",
                          FoodTitle = "Hủ tiếu khô xá xíu",
                          FoodDescription = "Hủ tíu khô + xá xíu + cải Tặng kèm 1 ly Trà La Hán Quả",
                          FoodPrice = 59000,
                          FoodPriceLess = 53100,
                          RestaurantId = 6
                      },

                       new Food
                       {
                           FoodId = 105,
                           FoodImageUrl = "./ImageForSeedData/Food/Restaurant6/food105.jpeg",
                           FoodTitle = "Đùi gà góc tư chiên mắm",
                           FoodDescription = "Đùi gà góc tư chiên giòn sốt mắm tỏi",
                           FoodPrice = 59000,
                           FoodPriceLess = 53100,
                           RestaurantId = 6
                       },

                       new Food
                       {
                           FoodId = 106,
                           FoodImageUrl = "./ImageForSeedData/Food/Restaurant6/food105.jpeg",
                           FoodTitle = "Hoàn thánh chiên",
                           FoodDescription = "4 viên",
                           FoodPrice = 39000,
                           FoodPriceLess = 35100,
                           RestaurantId = 6
                       },

                       new Food
                       {
                           FoodId = 107,
                           FoodImageUrl = "./ImageForSeedData/Food/Restaurant6/food107.jpg",
                           FoodTitle = "Hồng trà long nhãn",
                           FoodDescription = "",
                           FoodPrice = 39000,
                           FoodPriceLess = 35100,
                           RestaurantId = 6
                       },

                       new Food
                       {
                           FoodId = 108,
                           FoodImageUrl = "./ImageForSeedData/Food/Restaurant6/food105.jpeg",
                           FoodTitle = "Hồng trà chanh",
                           FoodDescription = "",
                           FoodPrice = 29000,
                           FoodPriceLess = 26100,
                           RestaurantId = 6
                       }
            );
        }
    }
}
