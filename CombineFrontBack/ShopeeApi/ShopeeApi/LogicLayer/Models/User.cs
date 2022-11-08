using ShopeeApi.EnumData;
using System.Text.Json.Serialization;

namespace ShopeeApi.Models
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; } = string.Empty;

        public byte[] PasswordSalt { get; set; }

        public byte[] PasswordHash { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Role Role { get; set; } = Role.User;

        public IEnumerable<SelectFoodRecord> SelectFoodRecords { set; get; }

        public IEnumerable<Bill> Bills { set; get; }

        public IEnumerable<RestaurantOrder> RestaurantOrders { set; get; } 

        //In Test
        public IEnumerable<TransferOrder> TransferOrders { set; get; }

        public IEnumerable<BillOrder> BillOrders { set; get; } 
        
    }
}