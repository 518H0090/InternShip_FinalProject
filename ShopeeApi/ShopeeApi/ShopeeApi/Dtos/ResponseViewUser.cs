using ShopeeApi.Models;

namespace ShopeeApi.Dtos
{
    public class ResponseViewUser
    {
        public string UserName { get; set; } = string.Empty;

        public Role Role { get; set; } 
    }
}
