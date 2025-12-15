using Microsoft.AspNetCore.Mvc;
using Vue_Marketeo_WebAPI.Services.HomeService.Infs;
using Vue_Marketeo_WebAPI.Services.HomeService.Results;

namespace Vue_Marketeo_WebAPI.Services.HomeService.Controller
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet]
        public RevenueDataResult GetRevenueData() 
        {
            return _homeService.GetRevenueData(); 
        }

        [HttpGet]
        public List<OrderResult> GetOrderList() 
        {
            return _homeService.GetOrderList();
        }

        [HttpGet]
        public List<TopProductResult> GetTopProductList()
        {
            return _homeService.GetTopProductList();
        }
    }
}
