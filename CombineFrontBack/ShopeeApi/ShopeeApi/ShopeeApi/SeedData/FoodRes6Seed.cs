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
                }
            );
        }
    }
}
