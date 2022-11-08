namespace ShopeeApi.Dtos.Request
{
    public class RequestUpdateResOrder
    {

        public string FoodTitle { set; get; } = string.Empty;

        public int CountFoodChoice { set; get; }

        public int RestaurantId { set; get; }

        public string UserName { set; get; } = string.Empty;
    }
}
