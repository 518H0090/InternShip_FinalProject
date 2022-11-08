using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopeeApi.Models;

namespace ShopeeApi.SeedData
{
    public class CategoryRes7Seed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
            (
                 new Category
                 {
                     CategoryId = 38,
                     CategoryName = "SIÊU SALE MÙA LỄ HỘI",
                     CategoryTag = "sieusalemualehoi",
                     RestaurantId = 7
                 },

                  new Category
                  {
                      CategoryId = 39,
                      CategoryName = "BÁNH BÒ",
                      CategoryTag = "banhbo",
                      RestaurantId = 7
                  },

                  new Category
                  {
                      CategoryId = 40,
                      CategoryName = "BÁNH DA LỢN",
                      CategoryTag = "banhdalon",
                      RestaurantId = 7
                  },

                  new Category
                  {
                      CategoryId = 41,
                      CategoryName = "RAU CÂU FLAN CHEESE",
                      CategoryTag = "raucauflancheese",
                      RestaurantId = 7
                  },

                  new Category
                  {
                      CategoryId = 42,
                      CategoryName = "RAU CÂU SƠN THỦY",
                      CategoryTag = "raucausonthuy",
                      RestaurantId = 7
                  },

                  new Category
                  {
                      CategoryId = 43,
                      CategoryName = "RAU CÂU DỪA",
                      CategoryTag = "raucaudua",
                      RestaurantId = 7
                  },

                  new Category
                  {
                      CategoryId = 44,
                      CategoryName = "KEM",
                      CategoryTag = "kem",
                      RestaurantId = 7
                  },

                  new Category
                  {
                      CategoryId = 45,
                      CategoryName = "COMBO",
                      CategoryTag = "combo",
                      RestaurantId = 7
                  },

                  new Category
                  {
                      CategoryId = 46,
                      CategoryName = "YOGHURT",
                      CategoryTag = "yoghurt",
                      RestaurantId = 7
                  },

                  new Category
                  {
                      CategoryId = 47,
                      CategoryName = "BÁNH FLAN",
                      CategoryTag = "banhflan",
                      RestaurantId = 7
                  },

                  new Category
                  {
                      CategoryId = 48,
                      CategoryName = "CHÈ",
                      CategoryTag = "che",
                      RestaurantId = 7
                  },

                  new Category
                  {
                      CategoryId = 49,
                      CategoryName = "CỐT DỪA",
                      CategoryTag = "cotdua",
                      RestaurantId = 7
                  }
            );
        }
    }
}