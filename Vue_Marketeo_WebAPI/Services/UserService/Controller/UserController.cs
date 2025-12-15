using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Vue_Marketeo_WebAPI.Models;
using Vue_Marketeo_WebAPI.Services.UserService.Infs;
using Vue_Marketeo_WebAPI.Services.UserService.Params;
using Vue_Marketeo_WebAPI.Services.UserService.Results;
using static Vue_Marketeo_WebAPI.Common.GlobalExceptionFilter;

namespace Vue_Marketeo_WebAPI.Services.UserService.Controller
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public LoginResult Login(LoginParam param) 
        {
            return _userService.Login(param);
        }
    }
}
