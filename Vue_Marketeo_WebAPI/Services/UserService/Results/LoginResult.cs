using Vue_Marketeo_WebAPI.Models;

namespace Vue_Marketeo_WebAPI.Services.UserService.Results
{
    public class LoginResult
    {
        public string Avatar { get; set; }

        public string Username { get; set; }

        public UserRole Role { get; set; }

        public string Token { get; set; }
    }
}
