using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopeeApi.Models;

namespace ShopeeApi.SeedData
{
    public class CategoryRes6Seed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
            (
                new Category
                {
                    CategoryId = 31,
                    CategoryName = "MÌ CỰC PHẨM",
                    CategoryTag = "micucpham",
                    RestaurantId = 6
                },

                 new Category
                 {
                     CategoryId = 32,
                     CategoryName = "SỦI CẢO / HOÀNH THÁNH",
                     CategoryTag = "suicaohoanhthanh",
                     RestaurantId = 6
                 },

                  new Category
                  {
                      CategoryId = 33,
                      CategoryName = "MÌ KHÔ",
                      CategoryTag = "mikho",
                      RestaurantId = 6
                  },

                   new Category
                   {
                       CategoryId = 34,
                       CategoryName = "MÌ NƯỚC",
                       CategoryTag = "minuoc",
                       RestaurantId = 6
                   },

                    new Category
                    {
                        CategoryId = 35,
                        CategoryName = "HỦ TIẾU KHÔ",
                        CategoryTag = "hutieukho",
                        RestaurantId = 6
                    },

                     new Category
                     {
                         CategoryId = 36,
                         CategoryName = "MÓN ĂN THÊM",
                         CategoryTag = "monanthem",
                         RestaurantId = 6
                     },

                      new Category
                      {
                          CategoryId = 37,
                          CategoryName = "TRÀ THANH NHIỆT",
                          CategoryTag = "trathanhnhiet",
                          RestaurantId = 6
                      }
            );
        }
    }
}