using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Vue_Marketeo_WebAPI.Common;
using Vue_Marketeo_WebAPI.Services.HomeService;
using Vue_Marketeo_WebAPI.Services.HomeService.Infs;
using Vue_Marketeo_WebAPI.Services.UserService;
using Vue_Marketeo_WebAPI.Services.UserService.Infs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IHomeService, HomeService>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddControllers(options => 
{
    options.Filters.Add<ResponseAttribute>();
    options.Filters.Add<GlobalExceptionFilter>();
});

//Ìí¼ÓJWTÈÏÖ¤
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = "buffz",
        ValidAudience = "buffz",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("RRAz5nI17fdIMi4Pb1FJOw6PRAOyTRBu"))
    };
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();