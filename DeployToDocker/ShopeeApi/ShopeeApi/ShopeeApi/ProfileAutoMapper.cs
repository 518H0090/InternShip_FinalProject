﻿using AutoMapper;
using ShopeeApi.Dtos.Request;
using ShopeeApi.Dtos.Response;
using ShopeeApi.Models;

namespace ShopeeApi
{
    public class ProfileAutoMapper : Profile
    {
        public ProfileAutoMapper()
        {
            CreateMap<User, ResponseUserRegister>();
            CreateMap<Restaurant, ResponseGetRestaurant>();
            CreateMap<ResponseGetRestaurant, Restaurant>();
            CreateMap<RequestAddRestaurant, Restaurant>();
            CreateMap<RequestEditRestaurant, Restaurant>();
            CreateMap<Category, ResponseGetCategory>();
            CreateMap<RequestAddCategory, Category>();
            CreateMap<RequestEditCategory, Category>();
            CreateMap<Restaurant, ResponseGetRestaurantWithCategoryTag>();
            CreateMap<RequestAddFood, Food>();
            CreateMap<Food, ResponseGetFood>();
            CreateMap<RequestFoodContainRestaurant, Food>();
            CreateMap<RequestUpdateFood, Food>();
            CreateMap<Restaurant, ResponseGetRestaurantWithFood>();
            CreateMap<Restaurant, ResponseGetRestaurantWithFoodTag>();
            CreateMap<RelationCategoryFood, ResponseGetFoodTag>();
            CreateMap<Category, ResponseGetCategoryCombineFood>();
            CreateMap<RelationCategoryFood, ResponseGetFoodTag>();
            CreateMap<Food, ResponseGetFoodCombineCategory>();
            CreateMap<RequestCategoryFood, RelationCategoryFood>();
            CreateMap<RequestFoodCombineCategory, RelationCategoryFood>();
            CreateMap<RequestCategoryCombineFood, RelationCategoryFood>();
            CreateMap<Restaurant, ResponseGetRestaurantWithId>();
            CreateMap<User, ResponseViewUser>();

            CreateMap<RequestAddResOrder, RestaurantOrder>();
            CreateMap<RestaurantOrder, ResponseRestaurantOrder>();
            CreateMap<RequestAddResOrder, RequestUpdateResOrder>();
            CreateMap<RequestDeleteRestaurantOrder, RequestUpdateResOrder>();

            CreateMap<RequestAddTransferOrder, TransferOrder>();
            CreateMap<TransferOrder, ResponseTransferOrder>();
            CreateMap<RequestDeleteTransferOrder, TransferOrder>();

            CreateMap<BillOrder, ResponseBillOrder>();
            CreateMap<RequestAddBillOrder, BillOrder>();
        }
    }
}