namespace ShopeeApi.Dtos.Request
{
    public class RequestAddFoodRecord
    {

        public string FoodImageUrl { set; get; } = string.Empty;

        public string FoodTitle { set; get; } = string.Empty;

        public string FoodDescription { set; get; } = string.Empty;

        public float FoodPrice { set; get; }

    }
}
