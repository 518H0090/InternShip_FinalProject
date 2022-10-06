using System.Text.Json.Serialization;

namespace ShopeeApi.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { set; get; } = string.Empty;

        public string CategoryTag { set; get; } = string.Empty;

        [JsonIgnore]
        public Restaurant Restaurant { set; get; }
        public int RestaurantId { get; set; }
    }
}