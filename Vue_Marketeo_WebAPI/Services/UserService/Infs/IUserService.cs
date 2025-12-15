using Vue_Marketeo_WebAPI.Models;
using Vue_Marketeo_WebAPI.Services.UserService.Params;
using Vue_Marketeo_WebAPI.Services.UserService.Results;

namespace Vue_Marketeo_WebAPI.Services.UserService.Infs
{
    public interface IUserService
    {
        LoginResult Login(LoginParam param);

        string GenerateJwtToken(User user);
    }
}
