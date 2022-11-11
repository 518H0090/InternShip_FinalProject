using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopeeApi.Models;

namespace ShopeeApi.SeedData
{
    public class CategoryRes4Seed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
            (
                new Category
                {
                    CategoryId = 15,
                    CategoryName = "KHUYẾN MÃI HOT",
                    CategoryTag = "khuyenmaihot",
                    RestaurantId = 4
                },

                new Category
                {
                    CategoryId = 16,
                    CategoryName = "COMBO HOT NƯỚC NGỌT",
                    CategoryTag = "combohotnuocngot",
                    RestaurantId = 4
                },

                new Category
                {
                    CategoryId = 17,
                    CategoryName = "MÌ QUẢNG",
                    CategoryTag = "miquang",
                    RestaurantId = 4
                },

                new Category
                {
                    CategoryId = 18,
                    CategoryName = "COMBO SIÊU TIẾT KIỆM 1 NGƯỜI",
                    CategoryTag = "combosieutietkiem1nguoi",
                    RestaurantId = 4
                },

                new Category
                {
                    CategoryId = 19,
                    CategoryName = "COMBO 3 TÔ",
                    CategoryTag = "combo3to",
                    RestaurantId = 4
                },

                new Category
                {
                    CategoryId = 20,
                    CategoryName = "MÓN THÊM",
                    CategoryTag = "monthem",
                    RestaurantId = 4
                },

                new Category
                {
                    CategoryId = 21,
                    CategoryName = "NƯỚC UỐNG",
                    CategoryTag = "nuocuong",
                    RestaurantId = 4
                },

                new Category
                {
                    CategoryId = 22,
                    CategoryName = "ĐẶC SẢN MIỀN TRUNG",
                    CategoryTag = "dacsanmientrung",
                    RestaurantId = 4
                }
            );
        }
    }
}