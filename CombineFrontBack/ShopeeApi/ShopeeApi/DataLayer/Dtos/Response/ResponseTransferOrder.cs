using ShopeeApi.EnumData;
using System.Text.Json.Serialization;

namespace ShopeeApi.Dtos.Response
{
    public class ResponseTransferOrder
    {
        public Guid OrderId { set; get; } = Guid.NewGuid();

        public string Username { set; get; } = string.Empty;

        public int NumberItem { set; get; }

        public int OrderDistance { set; get; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Promotion Promotion { set; get; }

        public int TempMoney { set; get; }

        public int TotalMoney { set; get; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ORDERSTATUS ORDERSTATUS { set; get; } = ORDERSTATUS.PROCESS;

        public string CreatedBy { set; get; } = string.Empty;
        public DateTime CreatedOn { set; get; }

        public string UpdatedBy { set; get; } = string.Empty;
        public DateTime UpdatedOn { set; get; }

        public int UserId { set; get; }
    }
}
