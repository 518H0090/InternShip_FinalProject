using DataLayer.StaticClass;

namespace ShopeeApi.Dtos.Response
{
    public class ResponseBillOrder
    {
        public Guid BillId { set; get; } = Guid.NewGuid();

        public int TotalMoney { set; get; }

        public string CreatedBy { set; get; } = string.Empty;

        public DateTime CreatedOn { set; get; } = DateTime.Now;

        public string UpdatedBy { set; get; } = string.Empty;

        public DateTime UpdatedOn { set; get; }

        public IEnumerable<ResponseTransferOrder> TransferOrders { set; get; }

        //In Test
        public string OrderCode { set; get; } 
    }
}