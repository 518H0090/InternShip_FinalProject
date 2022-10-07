namespace ShopeeApi.Models
{
    public class RelationCategoryFood
    {
        public Category Category { set; get; }
        public int CategoryId { get; set; }

        public Food Food { set; get; }
        public int FoodId { set; get; }
    }
}
