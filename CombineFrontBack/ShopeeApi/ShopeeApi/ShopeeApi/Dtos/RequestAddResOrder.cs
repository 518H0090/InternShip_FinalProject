namespace ShopeeApi.Dtos
{
    public class RequestAddResOrder
    {
        public string FoodImageUrl { set; get; } = string.Empty;

        public string FoodTitle { set; get; } = string.Empty;

        public string FoodDescription { set; get; } = string.Empty;

        public float FoodPrice { set; get; }

        public int RestaurantId { set; get; }

        public string UserName { set; get; } = string.Empty;
    }
}
