namespace ShopeeApi.Dtos
{
    public class ResponseGetBill
    {
        public Guid BillId { set; get; } = Guid.NewGuid();

        public float totalPayment { set; get; }

        public string UseName { set; get; } = string.Empty;

        public int UserId { set; get; }
    }
}
