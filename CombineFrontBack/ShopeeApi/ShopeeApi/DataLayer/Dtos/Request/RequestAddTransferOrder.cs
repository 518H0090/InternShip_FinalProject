using ShopeeApi.EnumData;
using System.Text.Json.Serialization;

namespace ShopeeApi.Dtos.Request
{
    public class RequestAddTransferOrder
    {
        public string Username { set; get; } = string.Empty;

        public int NumberItem { set; get; }

        public int OrderDistance { set; get; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Promotion? Promotion { set; get; }

        public int TempMoney { set; get; }

        public int RestaurantId { set; get; }
    }
}