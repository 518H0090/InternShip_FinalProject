using AutoMapper;
using ShopeeApi.Dtos;
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
        }
    }
}