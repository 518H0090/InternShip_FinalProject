using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopeeApi.EnumData;
using ShopeeApi.Models;

namespace ShopeeApi.SeedData
{
    public class RestaurantSeed : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.HasData
            (
                new Restaurant
                {
                    RsId = 1,
                    RsTitle = "Bếp Bà Muối - Ăn Vặt Online",
                    RsProvince = "TP.HCM",
                    RsAddress = "606/52 Đường 3 Tháng 2, P. 14, Quận 10, TP. HCM",
                    RsType = "QUANAN",
                    RsImageUrl = "./ImageForSeedData/Restaurant/restaurant1.jpg",
                    RsStar = 5,
                    RsReviews = 1,
                    RsOpenTime = "6:00 - 22:00",
                    RsPrinceRange = "44,000 - 85,000",
                    RsRefeLike = false,
                    RsPromotion = Promotion.reduceNone
                },

                new Restaurant
                {
                    RsId = 2,
                    RsTitle = "Royaltea Vietnam By Hongkong - Sơn Kỳ",
                    RsProvince = "TP.HCM",
                    RsAddress = "35 Sơn Kỳ, P. Sơn Kỳ, Tân Phú, TP. HCM",
                    RsType = "CAFE/DESSERT",
                    RsImageUrl = "./ImageForSeedData/Restaurant/restaurant2.jpg",
                    RsStar = 4.5f,
                    RsReviews = 500,
                    RsOpenTime = "8:15 - 22:20",
                    RsPrinceRange = "45,000 - 60,000",
                    RsRefeLike = false,
                    RsPromotion = Promotion.reduce50K
                },

                new Restaurant
                {
                    RsId = 3,
                    RsTitle = "Anh Thư - Bánh Mì & Bún Thịt Nướng",
                    RsProvince = "TP.HCM",
                    RsAddress = "115B Tôn Đản, P. 14, Quận 4, TP. HCM",
                    RsType = "ANVAT/VIAHE",
                    RsImageUrl = "./ImageForSeedData/Restaurant/restaurant3.jpg",
                    RsStar = 4.5f,
                    RsReviews = 999,
                    RsOpenTime = "6:00 - 20:11",
                    RsPrinceRange = "15,000 - 30,000",
                    RsRefeLike = false,
                    RsPromotion = Promotion.reduceNone
                },

                new Restaurant
                {
                    RsId = 4,
                    RsTitle = "Mì Quảng 3 Anh Em - Phạm Hùng",
                    RsProvince = "TP.HCM",
                    RsAddress = "322 Phạm Hùng, P. 4, Quận 8, TP. HCM",
                    RsType = "QUANAN",
                    RsImageUrl = "./ImageForSeedData/Restaurant/restaurant4.jpeg",
                    RsStar = 4.5f,
                    RsReviews = 100,
                    RsOpenTime = "7:00 - 21:30",
                    RsPrinceRange = "30,000 - 50,000",
                    RsRefeLike = true,
                    RsPromotion = Promotion.reduce
                },

                new Restaurant
                {
                    RsId = 5,
                    RsTitle = "Kim Milk Tea - Trà Sữa, Nước Ép & Ăn Vặt",
                    RsProvince = "TP.HCM",
                    RsAddress = "38 Đường Số 13, P. Bình Thọ, Thủ Đức, TP. HCM",
                    RsType = "CAFE/DESSERT",
                    RsImageUrl = "./ImageForSeedData/Restaurant/restaurant5.jpg",
                    RsStar = 4.5f,
                    RsReviews = 999,
                    RsOpenTime = "9:00 - 21:00",
                    RsPrinceRange = "14,000 - 30,000",
                    RsRefeLike = false,
                    RsPromotion = Promotion.reduce10K
                },
                new Restaurant
                {
                    RsId = 6,
                    RsTitle = "Min Kee - Mì Khô & Trà Hong Kong",
                    RsProvince = "TP.HCM",
                    RsAddress = "122 Nguyễn Khoái, P. 2, Quận 4, TP. HCM",
                    RsType = "QUANAN",
                    RsImageUrl = "./ImageForSeedData/Restaurant/restaurant6.jpg",
                    RsStar = 4.5f,
                    RsReviews = 999,
                    RsOpenTime = "7:20 - 21:45",
                    RsPrinceRange = "15,000 - 69,000",
                    RsRefeLike = false,
                    RsPromotion = Promotion.reduce10K
                },

                new Restaurant
                {
                    RsId = 7,
                    RsTitle = "Bánh Bò Thốt Nốt COCOCake - Lò Bánh Minh Khai",
                    RsProvince = "TP.HCM",
                    RsAddress = "18A/29 Nguyễn Thị Minh Khai, P. Đa Kao, Quận 1, TP. HCM",
                    RsType = "QUANAN",
                    RsImageUrl = "./ImageForSeedData/Restaurant/restaurant7.jpg",
                    RsStar = 4.5f,
                    RsReviews = 999,
                    RsOpenTime = "8:30 - 20:25",
                    RsPrinceRange = "95,000 - 150,000",
                    RsRefeLike = true,
                    RsPromotion = Promotion.reduce
                },

                new Restaurant
                {
                    RsId = 8,
                    RsTitle = "Việt - Cơm Chay",
                    RsProvince = "TP.HCM",
                    RsAddress = "26 Huỳnh Lan Khanh, P. 2, Tân Bình, TP. HCM",
                    RsType = "ANCHAY",
                    RsImageUrl = "./ImageForSeedData/Restaurant/restaurant8.jpg",
                    RsStar = 4.5f,
                    RsReviews = 999,
                    RsOpenTime = "7:00 - 20:45",
                    RsPrinceRange = "20,000 - 100,000",
                    RsRefeLike = false,
                    RsPromotion = Promotion.reduce
                },

                new Restaurant
                {
                    RsId = 9,
                    RsTitle = "Bánh Quế Hà Lan - Huỳnh Văn Bánh",
                    RsProvince = "TP.HCM",
                    RsAddress = "420/11 Huỳnh Văn Bánh, P. 14, Phú Nhuận, TP. HCM",
                    RsType = "TIEMBANH",
                    RsImageUrl = "./ImageForSeedData/Restaurant/restaurant9.jpeg",
                    RsStar = 4.5f,
                    RsReviews = 50,
                    RsOpenTime = "9:00 - 19:00",
                    RsPrinceRange = "105,000 - 150,000",
                    RsRefeLike = false,
                    RsPromotion = Promotion.reduceNone
                }

            );
        }
    }
}