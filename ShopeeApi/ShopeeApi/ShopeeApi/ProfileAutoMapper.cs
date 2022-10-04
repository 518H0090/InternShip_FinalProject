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
        }
    }
}
