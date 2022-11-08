using ShopeeApi.Dtos.Request;
using ShopeeApi.Dtos.Response;
using ShopeeApi.Service;

namespace ShopeeApi.IRepository
{
    public interface IUserRepository
    {
        Task<ServiceResponse<ResponseUserRegister>> Register(RequestUserRegister request);

        Task<ServiceResponse<string>> AuthenLogin(RequestUserLogin request);

        Task<ServiceResponse<ResponseViewUser>> ViewUserInfo(string jwtToken);
    }
}