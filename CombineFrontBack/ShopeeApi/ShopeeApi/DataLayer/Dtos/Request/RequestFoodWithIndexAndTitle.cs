namespace ShopeeApi.Dtos.Request
{
    public class RequestFoodWithIndexAndTitle
    {
        public int indexpage { set; get; }
        public string keywords { set; get; } = string.Empty;
    }
}
