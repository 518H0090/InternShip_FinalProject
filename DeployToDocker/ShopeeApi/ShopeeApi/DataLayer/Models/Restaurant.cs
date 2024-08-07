﻿using ShopeeApi.EnumData;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ShopeeApi.Models
{
    public class Restaurant
    {
        public int RsId { get; set; }

        public string RsTitle { set; get; } = string.Empty;

        public string RsProvince { set; get; } = string.Empty;

        public string RsAddress { set; get; } = string.Empty;

        public string RsType { set; get; } = string.Empty;

        public string RsImageUrl { set; get; } = string.Empty;

        [Range(1, 5)]
        public float RsStar { set; get; }

        public int RsReviews { set; get; }

        public string RsOpenTime { set; get; } = string.Empty;

        public string RsPrinceRange { set; get; } = string.Empty;

        public bool RsRefeLike { set; get; } = false;

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Promotion? RsPromotion { set; get; }

        public IEnumerable<Category> Categories { set; get; }

        public IEnumerable<Food> Foods { set; get; }

        public IEnumerable<RestaurantOrder> RestaurantOrders { set; get; }

        //In Test
        public int RsDistance { set; get; } = new Random().Next(1, 30);
    }
}