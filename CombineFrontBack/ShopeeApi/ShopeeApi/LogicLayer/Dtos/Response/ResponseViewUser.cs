using ShopeeApi.EnumData;
using System.Text.Json.Serialization;

namespace ShopeeApi.Dtos.Response
{
    public class ResponseViewUser
    {
        public string UserName { get; set; } = string.Empty;

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Role Role { get; set; }
    }
}