namespace ShopeeApi.Dtos
{
    public class ResponseGetFood
    {
        //Temp
        public int FoodId { set; get; }

        public string FoodImageUrl { set; get; } = string.Empty;

        public string FoodTitle { set; get; } = string.Empty;

        public string FoodDescription { set; get; } = string.Empty;

        public int FoodPrice { set; get; }

        public float FoodPriceLess { set; get; }
    }
}