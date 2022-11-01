using System.Text.Json.Serialization;

namespace ShopeeApi.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ORDERSTATUS
    {
        PROCESS = 1,
        FINISH = 2
    }
}
