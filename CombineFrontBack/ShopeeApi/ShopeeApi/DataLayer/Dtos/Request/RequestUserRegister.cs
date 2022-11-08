namespace ShopeeApi.Dtos.Request
{
    public class RequestUserRegister
    {
        public string UserName { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string RePassword { get; set; } = string.Empty;
    }
}