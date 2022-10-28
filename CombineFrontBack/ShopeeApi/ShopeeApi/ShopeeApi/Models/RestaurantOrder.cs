namespace ShopeeApi.Models
{
    public class RestaurantOrder
    {
        public int OrderId { set; get; }

        public string FoodImageUrl { set; get; } = string.Empty;

        public string FoodTitle { set; get; } = string.Empty;

        public string FoodDescription { set; get; } = string.Empty;

        public float FoodPrice { set; get; }

        public int CountFoodChoice { set; get; }

        public string CreatedBy { set; get; } = string.Empty;

        public DateTime CreatedOn { set; get; } = DateTime.Now;

        public string UpdatedBy { set; get; } = string.Empty;

        public DateTime UpdatedOn { set; get; }

        public Restaurant Restaurant { set; get; }
        public int RestaurantId { set; get; }

        public User User { set; get; }
        public int UserId { set; get; }

    }
}
