using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopeeApi.Models;

namespace ShopeeApi.SeedData
{
    public class FoodRes4Seed : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData
            (
                new Food
                {
                    FoodId = 52,
                    FoodImageUrl = "./ImageForSeedData/Food/Restaurant4/food52.jpeg",
                    FoodTitle = "Mì Quảng thịt, trứng cút",
                    FoodDescription = "Gọi 0906743795 Hổ trợ nhanh nhất nhé cảm ơn ạ ^^",
                    FoodPrice = 55000,
                    FoodPriceLess = 49500,
                    RestaurantId = 4
                },

                new Food
                {
                    FoodId = 53,
                    FoodImageUrl = "./ImageForSeedData/Food/Restaurant4/food53.jpeg",
                    FoodTitle = "Mì Quảng Chả Nhỏ",
                    FoodDescription = "",
                    FoodPrice = 50000,
                    FoodPriceLess = 45000,
                    RestaurantId = 4
                },

                 new Food
                 {
                     FoodId = 54,
                     FoodImageUrl = "./ImageForSeedData/Food/Restaurant4/food54.jpeg",
                     FoodTitle = "Mì Quảng Chả cua",
                     FoodDescription = "Gọi 0906743795 Hỗ trợ nha",
                     FoodPrice = 55000,
                     FoodPriceLess = 49500,
                     RestaurantId = 4
                 },

                 new Food
                 {
                     FoodId = 55,
                     FoodImageUrl = "./ImageForSeedData/Food/Restaurant4/food55.jpeg",
                     FoodTitle = "Mì Quảng bắp bò + chả",
                     FoodDescription = "",
                     FoodPrice = 60000,
                     FoodPriceLess = 54000,
                     RestaurantId = 4
                 },

                 new Food
                 {
                     FoodId = 56,
                     FoodImageUrl = "./ImageForSeedData/Food/Restaurant4/food56.jpeg",
                     FoodTitle = "Mì Quảng sườn non + chả",
                     FoodDescription = "",
                     FoodPrice = 60000,
                     FoodPriceLess = 54000,
                     RestaurantId = 4
                 },

                 new Food
                 {
                     FoodId = 57,
                     FoodImageUrl = "./ImageForSeedData/Food/Restaurant4/food57.jpeg",
                     FoodTitle = "Chén tôm thêm",
                     FoodDescription = "",
                     FoodPrice = 50000,
                     FoodPriceLess = 45000,
                     RestaurantId = 4
                 },

                 new Food
                 {
                     FoodId = 58,
                     FoodImageUrl = "./ImageForSeedData/Food/Restaurant4/food58.jpeg",
                     FoodTitle = "Mì Quảng Đặt biệt",
                     FoodDescription = "0906743795 Hổ trợ nhanh nhất nhé cảm ơn ạ ^^",
                     FoodPrice = 70000,
                     FoodPriceLess = 63000,
                     RestaurantId = 4
                 },

                  new Food
                  {
                      FoodId = 59,
                      FoodImageUrl = "./ImageForSeedData/Food/Restaurant4/food59.jpeg",
                      FoodTitle = "Mì Quảng gà chọi rút xương",
                      FoodDescription = "0906743795 Hổ trợ nhanh nhất nhé cảm ơn ạ ^^",
                      FoodPrice = 60000,
                      FoodPriceLess = 54000,
                      RestaurantId = 4
                  },

                  new Food
                  {
                      FoodId = 60,
                      FoodImageUrl = "./ImageForSeedData/Food/Restaurant4/food60.jpeg",
                      FoodTitle = "Mì Quảng tôm thịt",
                      FoodDescription = "0906743795 Hổ trợ nhanh nhất nhé cảm ơn ạ ^^",
                      FoodPrice = 55000,
                      FoodPriceLess = 49500,
                      RestaurantId = 4
                  },

                   new Food
                   {
                       FoodId = 61,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant4/food61.jpg",
                       FoodTitle = "Combo 1 tô mì quảng chọn món + 1 pepsi/nước suối",
                       FoodDescription = "TẶNG KÈM TƯƠNG ỚT HỘI AN SIÊU NGON",
                       FoodPrice = 65000,
                       FoodPriceLess = 58500,
                       RestaurantId = 4
                   },

                   new Food
                   {
                       FoodId = 62,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant4/food62.jpeg",
                       FoodTitle = "Combo 3 tô mì quảng đặc biệt 3 anh em",
                       FoodDescription = "0906743795 Hổ trợ nhanh nhất nhé cảm ơn ạ ^^",
                       FoodPrice = 215000,
                       FoodPriceLess = 193500,
                       RestaurantId = 4
                   },

                   new Food
                   {
                       FoodId = 63,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant4/food63.jpeg",
                       FoodTitle = "Combo 3 tô mì Quảng gà chọi rút xương",
                       FoodDescription = "Hổ trợ nhanh nhất nhé cảm ơn ạ ^^",
                       FoodPrice = 180000,
                       FoodPriceLess = 162000,
                       RestaurantId = 4
                   },

                   new Food
                   {
                       FoodId = 64,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant4/food64.jpeg",
                       FoodTitle = "Combo 3 tô mì Quảng Thit trứng cút",
                       FoodDescription = "0906743795 Hổ trợ nhanh nhất nhé cảm ơn ạ ^^",
                       FoodPrice = 165000,
                       FoodPriceLess = 148500,
                       RestaurantId = 4
                   },

                   new Food
                   {
                       FoodId = 65,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant4/food65.jpg",
                       FoodTitle = "Bánh tráng thêm",
                       FoodDescription = "",
                       FoodPrice = 10000,
                       FoodPriceLess = 9000,
                       RestaurantId = 4
                   },

                   new Food
                   {
                       FoodId = 66,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant4/food66.jpg",
                       FoodTitle = "Rau thêm",
                       FoodDescription = "",
                       FoodPrice = 10000,
                       FoodPriceLess = 9000,
                       RestaurantId = 4
                   },

                   new Food
                   {
                       FoodId = 67,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant4/food67.jpg",
                       FoodTitle = "Pepsi",
                       FoodDescription = "",
                       FoodPrice = 20000,
                       FoodPriceLess = 18000,
                       RestaurantId = 4
                   },

                   new Food
                   {
                       FoodId = 68,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant4/food68.jpg",
                       FoodTitle = "7up",
                       FoodDescription = "",
                       FoodPrice = 20000,
                       FoodPriceLess = 18000,
                       RestaurantId = 4
                   },

                   new Food
                   {
                       FoodId = 69,
                       FoodImageUrl = "./ImageForSeedData/Food/Restaurant4/food69.jpeg",
                       FoodTitle = "Bánh tráng gạo 300gram",
                       FoodDescription = "",
                       FoodPrice = 55000,
                       FoodPriceLess = 49500,
                       RestaurantId = 4
                   },

                    new Food
                    {
                        FoodId = 70,
                        FoodImageUrl = "./ImageForSeedData/Food/Restaurant4/food70.jpeg",
                        FoodTitle = "Tương ớt hội an",
                        FoodDescription = "1 hủ",
                        FoodPrice = 90000,
                        FoodPriceLess = 81000,
                        RestaurantId = 4
                    }
            );
        }
    }
}