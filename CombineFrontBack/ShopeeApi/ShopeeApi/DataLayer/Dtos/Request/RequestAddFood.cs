﻿namespace ShopeeApi.Dtos.Request
{
    public class RequestAddFood
    {
        public string FoodImageUrl { set; get; } = string.Empty;

        public string FoodTitle { set; get; } = string.Empty;

        public string FoodDescription { set; get; } = string.Empty;

        public int FoodPrice { set; get; }

        public int RestaurantId { set; get; }
    }
}