namespace ShopeeApi.Service
{
    public class ServiceResponse<T>
    {
        public T? Data { set; get; }

        public bool Success { set; get; } = true;

        public string Message { set; get; } = string.Empty;
    }
}