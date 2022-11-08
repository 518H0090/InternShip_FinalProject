namespace ShopeeApi.Models
{
    public class BillOrder
    {

        public Guid BillId { set; get; } = Guid.NewGuid();

        public int TotalMoney { set; get; }

        public string CreatedBy { set; get; } = string.Empty;

        public DateTime CreatedOn { set; get; } = DateTime.Now;

        public string UpdatedBy { set; get; } = string.Empty;

        public DateTime UpdatedOn { set; get; }

        public IEnumerable<TransferOrder> TransferOrders { set; get; }

        public User User { set; get; }
        public int UserId { set; get; }

    }
}
