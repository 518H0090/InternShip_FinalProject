using System.Text.Json.Serialization;

namespace ShopeeApi.EnumData
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ORDERSTATUS
    {
        PROCESS = 1,
        FINISH = 2
    }
}