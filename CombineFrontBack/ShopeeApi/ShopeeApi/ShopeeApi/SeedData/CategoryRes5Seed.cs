using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopeeApi.Models;

namespace ShopeeApi.SeedData
{
    public class CategoryRes5Seed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
            (
                new Category
                {
                    CategoryId = 23,
                    CategoryName = "NOWFOOD DAY",
                    CategoryTag = "nowfoodday",
                    RestaurantId = 5
                },

                 new Category
                 {
                     CategoryId = 24,
                     CategoryName = "COMBO TRÀ SỮA",
                     CategoryTag = "combotrasua",
                     RestaurantId = 5
                 },

                  new Category
                  {
                      CategoryId = 25,
                      CategoryName = "TRÀ TRÁI CÂY NHIỆT ĐỚI",
                      CategoryTag = "tratraicaynhietdoi",
                      RestaurantId = 5
                  },

                   new Category
                   {
                       CategoryId = 26,
                       CategoryName = "SỮA TƯƠI ĐƯỜNG ĐEN",
                       CategoryTag = "suatuoiduongden",
                       RestaurantId = 5
                   },

                    new Category
                    {
                        CategoryId = 27,
                        CategoryName = "TRÀ SỮA",
                        CategoryTag = "trasua",
                        RestaurantId = 5
                    },

                     new Category
                     {
                         CategoryId = 28,
                         CategoryName = "LỤC TRÀ",
                         CategoryTag = "luctra",
                         RestaurantId = 5
                     },

                      new Category
                      {
                          CategoryId = 29,
                          CategoryName = "NƯỚC ÉP TRÁI CÂY TƯƠI",
                          CategoryTag = "nuoceptraicaytuoi",
                          RestaurantId = 5
                      },

                       new Category
                       {
                           CategoryId = 30,
                           CategoryName = "COMBO COUPLE",
                           CategoryTag = "combocouple",
                           RestaurantId = 5
                       }
            );
        }
    }
}
