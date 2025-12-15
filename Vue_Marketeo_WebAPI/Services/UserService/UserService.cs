using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Vue_Marketeo_WebAPI.Models;
using Vue_Marketeo_WebAPI.Services.UserService.Infs;
using Vue_Marketeo_WebAPI.Services.UserService.Params;
using Vue_Marketeo_WebAPI.Services.UserService.Results;
using static Vue_Marketeo_WebAPI.Common.GlobalExceptionFilter;

namespace Vue_Marketeo_WebAPI.Services.UserService
{
    public class UserService : IUserService
    {
        private static readonly List<User> _users = new()
        {
            new User { Id = 1, Username = "admin", Password = "admin123", Role = UserRole.Admin },
            new User { Id = 2, Username = "manager", Password = "manager123", Role = UserRole.Manager},
            new User { Id = 3, Username = "user", Password = "user123", Role = UserRole.User }
        };

        public string GenerateJwtToken(User user)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role, user.Role.ToString()),
            };

            var token = new JwtSecurityToken(
                issuer: "buffz",
                audience: "buffz",
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes("RRAz5nI17fdIMi4Pb1FJOw6PRAOyTRBu")), SecurityAlgorithms.HmacSha256)
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public LoginResult Login(LoginParam param)
        {
            var user = _users
                .Where(x => x.Username == param.Username && x.Password == param.Password)
                .FirstOrDefault();

            if (user == null)
                throw new ApiException(500, "未找到该用户信息");

            var token = GenerateJwtToken(user);

            return new LoginResult
            {
                Avatar = user.Avatar,
                Role = user.Role,
                Username = user.Username,
                Token = token
            };
        }
    }
}
