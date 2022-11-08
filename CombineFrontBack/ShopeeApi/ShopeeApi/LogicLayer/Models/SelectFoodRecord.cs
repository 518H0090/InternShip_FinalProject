using System.Text.Json.Serialization;

namespace ShopeeApi.Models
{
    public class SelectFoodRecord
    {
        public int RecordId { set; get; }

        public string FoodImageUrl { set; get; } = string.Empty;

        public string FoodTitle { set; get; } = string.Empty;

        public string FoodDescription { set; get; } = string.Empty;

        public float FoodPrice { set; get; }

        [JsonIgnore]
        public User User { set; get; }
        public int UserId { set; get; }
    }
}
