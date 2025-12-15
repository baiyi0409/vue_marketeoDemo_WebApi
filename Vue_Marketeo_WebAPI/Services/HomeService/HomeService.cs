using Vue_Marketeo_WebAPI.Services.HomeService.Infs;
using Vue_Marketeo_WebAPI.Services.HomeService.Results;

namespace Vue_Marketeo_WebAPI.Services.HomeService
{
    public class HomeService : IHomeService
    {
        public RevenueDataResult GetRevenueData()
        {
            RevenueDataResult revenueDataResult = new RevenueDataResult()
            {
                TotalRevenue = 17086.92,
                TotalPercentage = 8.34,
                Type = RevenueType.Monthly,
                Revenue = 9721.54
            };
            return revenueDataResult;
        }

        public List<OrderResult> GetOrderList()
        {
            List<OrderResult> orderResults = new List<OrderResult>()
            {
                new OrderResult(){ Id=1,ProductName="Barhat blue",Date="May 5",Status=OrderStatus.Received,Price="359.90",Customer="M-Starlight" },
                new OrderResult(){ Id=2,ProductName="Soft Ginger",Date="May 4",Status=OrderStatus.Received,Price="420.78",Customer="Serene W"}
            };
            return orderResults;
        }


        public List<TopProductResult> GetTopProductList()
        {
            List<TopProductResult> topProductResults = new List<TopProductResult>()
            {
                new TopProductResult(){ Id=1, ImgUrl="", ProductName="Emerald Velvet", SoldNum=917, Price=355.90  },
                new TopProductResult(){ Id=2, ImgUrl="", ProductName="Velvet Coral", SoldNum=804, Price=279.00, },
                new TopProductResult(){ Id=2, ImgUrl="", ProductName="Rotterdam", SoldNum=738, Price=329.95, },
                new TopProductResult(){ Id=2, ImgUrl="", ProductName="Happy Yellow", SoldNum=684, Price=315.50, },
            };
            return topProductResults;
        }
    }
}
