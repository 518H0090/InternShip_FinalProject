using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ShopeeApi.Models;

namespace ShopeeApi.Dtos
{
    public class RequestDeleteTransferOrder
    {
        public Guid OrderId { set; get; } 

        public string Username { set; get; } = string.Empty;

    }
}
