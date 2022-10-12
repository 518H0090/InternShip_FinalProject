using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopeeApi.Models;

namespace ShopeeApi.SeedData
{
    public class FoodRes7Seed : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData
            (
                 new Food
                 {
                     FoodId = 109,
                     FoodImageUrl = "./ImageForSeedData/Food/Restaurant7/food109.jpeg",
                     FoodTitle = "Bánh bò nướng (hộp 1 lát lớn)",
                     FoodDescription = "Bánh bò nướng đường thốt nốt",
                     FoodPrice = 22000,
                     FoodPriceLess = 11000,
                     RestaurantId = 7
                 },

                   new Food
                   {
                       FoodId = 110,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant7/food110.jpeg",
                       FoodTitle = "Rau câu sơn thủy hộp nhỏ (350g)",
                       FoodDescription = "Rau câu sơn thủy, bao gồm nhiều vị trong cùng một miếng rau câu: cốt dừa, cà phê, rau câu, lá dứa",
                       FoodPrice = 45000,
                       FoodPriceLess = 40500,
                       RestaurantId = 7
                   },

                   new Food
                   {
                       FoodId = 111,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant7/food111.jpeg",
                       FoodTitle = "Hộp 2 lát bánh bò nhỏ",
                       FoodDescription = "Gồm: nước cốt dừa tươi, đường thốt nốt, trứng gà tươi, bột",
                       FoodPrice = 35000,
                       FoodPriceLess = 31500,
                       RestaurantId = 7
                   },

                   new Food
                   {
                       FoodId = 112,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant7/food112.jpeg",
                       FoodTitle = "Bánh bò nhỏ (550g)",
                       FoodDescription = "Bánh bò nướng đường thốt nốt",
                       FoodPrice = 110000,
                       FoodPriceLess = 99000,
                       RestaurantId = 7
                   },

                   new Food
                   {
                       FoodId = 113,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant7/food113.jpeg",
                       FoodTitle = "Bánh bò lớn (900g)",
                       FoodDescription = "Bánh bò nướng đường thốt nốt",
                       FoodPrice = 170000,
                       FoodPriceLess = 153000,
                       RestaurantId = 7
                   },

                   new Food
                   {
                       FoodId = 114,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant7/food114.jpeg",
                       FoodTitle = "Hộp 4 lát bánh bò nhỏ",
                       FoodDescription = "Bánh bò nướng đường thốt nốt",
                       FoodPrice = 60000,
                       FoodPriceLess = 54000,
                       RestaurantId = 7
                   },

                   new Food
                   {
                       FoodId = 115,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant7/food115.jpeg",
                       FoodTitle = "Da lợn cuộn 2 vị hộp 6 khoanh",
                       FoodDescription = "Bánh da lợn có thành phần chính từ lá cẩm khoai môn",
                       FoodPrice = 60000,
                       FoodPriceLess = 54000,
                       RestaurantId = 7
                   },

                   new Food
                   {
                       FoodId = 116,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant7/food116.jpeg",
                       FoodTitle = "Da lợn cuộn 2 vị hộp 8 khoanh",
                       FoodDescription = "Bánh da lợn có thành phần chính từ lá cẩm khoai môn",
                       FoodPrice = 75000,
                       FoodPriceLess = 67500,
                       RestaurantId = 7
                   },

                    new Food
                    {
                        FoodId = 117,
                        FoodImageUrl = "./ImageForSeedData/Food/Restaurant7/food117.jpeg",
                        FoodTitle = "Da lợn cuộn Đậu xanh lá dứa hộp 6 khoanh",
                        FoodDescription = "Bánh da lợn có thành phần chính từ lá dứa, đậu xanh",
                        FoodPrice = 60000,
                        FoodPriceLess = 54000,
                        RestaurantId = 7
                    },

                    new Food
                    {
                        FoodId = 118,
                        FoodImageUrl = "./ImageForSeedData/Food/Restaurant7/food118.jpeg",
                        FoodTitle = "Flan cheese Cà phê hộp nhỏ (600g)",
                        FoodDescription = "Rau câu dẻo, lớp rau câu cà phê và flan phô mai xen kẽ nhau tạo thành từng lớp",
                        FoodPrice = 95000,
                        FoodPriceLess = 85500,
                        RestaurantId = 7
                    },

                    new Food
                    {
                        FoodId = 119,
                        FoodImageUrl = "./ImageForSeedData/Food/Restaurant7/food119.jpeg",
                        FoodTitle = "Flan cheese Cà phê hộp lớn (900g)",
                        FoodDescription = "Rau câu dẻo, lớp rau câu cà phê và flan phô mai xen kẽ nhau tạo thành từng lớp",
                        FoodPrice = 140000,
                        FoodPriceLess = 126000,
                        RestaurantId = 7
                    },

                     new Food
                     {
                         FoodId = 120,
                         FoodImageUrl = "./ImageForSeedData/Food/Restaurant7/food120.jpeg",
                         FoodTitle = "Rau câu sơn thủy hộp lớn (600g)",
                         FoodDescription = "Rau câu sơn thủy, bao gồm nhiều vị trong cùng một miếng rau câu: cốt dừa, cà phê, rau câu, lá dứa",
                         FoodPrice = 75000,
                         FoodPriceLess = 67500,
                         RestaurantId = 7
                     },

                      new Food
                      {
                          FoodId = 121,
                          FoodImageUrl = "./ImageForSeedData/Food/Restaurant7/food121.jpeg",
                          FoodTitle = "Rau câu dừa hộp nhỏ (600g)",
                          FoodDescription = "Rau câu dẻo được làm từ nước cốt và nước dừa tươi",
                          FoodPrice = 85000,
                          FoodPriceLess = 76500,
                          RestaurantId = 7
                      },

                      new Food
                      {
                          FoodId = 122,
                          FoodImageUrl = "./ImageForSeedData/Food/Restaurant7/food122.jpeg",
                          FoodTitle = "Hộp kem Nhãn nhỏ 250g",
                          FoodDescription = "",
                          FoodPrice = 95000,
                          FoodPriceLess = 85500,
                          RestaurantId = 7
                      },

                      new Food
                      {
                          FoodId = 123,
                          FoodImageUrl = "./ImageForSeedData/Food/Restaurant7/food123.jpeg",
                          FoodTitle = "Combo B: 1 Bánh bò nhỏ (550g) + Hộp kem dừa 250gr",
                          FoodDescription = "Hình ảnh mang tính chất minh họa",
                          FoodPrice = 195000,
                          FoodPriceLess = 175500,
                          RestaurantId = 7
                      },

                       new Food
                       {
                           FoodId = 124,
                           FoodImageUrl = "./ImageForSeedData/Food/Restaurant7/food124.jpeg",
                           FoodTitle = "Yoghurt",
                           FoodDescription = "",
                           FoodPrice = 22000,
                           FoodPriceLess = 19800,
                           RestaurantId = 7
                       },

                       new Food
                       {
                           FoodId = 125,
                           FoodImageUrl = "./ImageForSeedData/Food/Restaurant7/food125.jpeg",
                           FoodTitle = "Bánh Flan Vị Truyền Thống",
                           FoodDescription = "",
                           FoodPrice = 22000,
                           FoodPriceLess = 19800,
                           RestaurantId = 7
                       },

                       new Food
                       {
                           FoodId = 126,
                           FoodImageUrl = "./ImageForSeedData/Food/Restaurant7/food126.jpeg",
                           FoodTitle = "Chè Bưởi (Đường Thốt Nốt) 200g☘",
                           FoodDescription = "Chè bưởi kèm cốt dừa chan",
                           FoodPrice = 35000,
                           FoodPriceLess = 31500,
                           RestaurantId = 7
                       },

                       new Food
                       {
                           FoodId = 127,
                           FoodImageUrl = "./ImageForSeedData/Food/Restaurant7/food127.jpeg",
                           FoodTitle = "Cốt dừa chén nhỏ 50ml (lạnh)",
                           FoodDescription = "50ml cốt dừa (lạnh)",
                           FoodPrice = 6000,
                           FoodPriceLess = 5400,
                           RestaurantId = 7
                       }
            );
        }
    }
}