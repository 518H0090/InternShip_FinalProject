namespace ShopeeApi.Models
{
    public class Bill
    {
        public Guid BillId { set; get; } = Guid.NewGuid();

        public float totalPayment { set; get; }

        public string UseName { set; get; } = string.Empty;

        public User User { set; get; }
        public int UserId { set; get; }

    }
}
