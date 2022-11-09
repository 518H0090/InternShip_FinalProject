namespace ShopeeApi.Dtos.Request
{
    public class RequestFoodWithIndexAndResType
    {
        public int indexpage { set; get; }

        public string restype { set; get; } = string.Empty;
    }
}