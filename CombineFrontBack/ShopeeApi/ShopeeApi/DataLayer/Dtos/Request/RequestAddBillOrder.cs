namespace ShopeeApi.Dtos.Request
{
    public class RequestAddBillOrder
    {
        public Guid OrderId { set; get; } = Guid.NewGuid();

        public string CreatedBy { set; get; } = string.Empty;

        public int TotalMoney { set; get; }

    }
}
