namespace ShopeeApi.Dtos.Request
{
    public class RequestDeleteRestaurantOrder
    {
        public string FoodTitle { set; get; } = string.Empty;

        public string UserName { set; get; } = string.Empty;

        public int RestaurantId { set; get; }
    }
}
