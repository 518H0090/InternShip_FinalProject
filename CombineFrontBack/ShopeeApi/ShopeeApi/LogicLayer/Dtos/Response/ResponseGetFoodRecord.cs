namespace ShopeeApi.Dtos.Response
{
    public class ResponseGetFoodRecord
    {
        public int RecordId { set; get; }

        public string FoodImageUrl { set; get; } = string.Empty;

        public string FoodTitle { set; get; } = string.Empty;

        public string FoodDescription { set; get; } = string.Empty;

        public float FoodPrice { set; get; }

    }
}
