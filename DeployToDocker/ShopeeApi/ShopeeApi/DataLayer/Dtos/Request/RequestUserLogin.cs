﻿namespace ShopeeApi.Dtos.Request
{
    public class RequestUserLogin
    {
        public string UserName { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }
}