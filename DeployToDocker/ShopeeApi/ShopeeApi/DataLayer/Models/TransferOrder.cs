﻿using DataLayer.StaticClass;
using Newtonsoft.Json.Converters;
using ShopeeApi.EnumData;
using System.Text.Json.Serialization;

namespace ShopeeApi.Models
{
    public class TransferOrder
    {
        public Guid OrderId { set; get; } = Guid.NewGuid();

        public string Username { set; get; } = string.Empty;

        public int NumberItem { set; get; }

        public int OrderDistance { set; get; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Promotion Promotion { set; get; } = Promotion.reduceNone;

        public int TempMoney { set; get; }

        public int TotalMoney { set; get; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ORDERSTATUS ORDERSTATUS { set; get; } = ORDERSTATUS.PROCESS;

        public string CreatedBy { set; get; } = string.Empty;
        public DateTime CreatedOn { set; get; } = DateTime.Now;

        public string UpdatedBy { set; get; } = string.Empty;
        public DateTime UpdatedOn { set; get; }

        public User User { set; get; }
        public int UserId { set; get; }

        public BillOrder? BillOrder { set; get; }
        public Guid? BillOrderId { set; get; }

        //In Test
        public string OrderCode { set; get; } = RandomString.RandomStringSequence();
    }
}