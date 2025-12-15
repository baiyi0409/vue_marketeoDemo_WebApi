using Vue_Marketeo_WebAPI.Services.HomeService.Results;

namespace Vue_Marketeo_WebAPI.Services.HomeService.Infs
{
    public interface IHomeService
    {
        //Task<RevenueDataResult> GetRevenueData();
        RevenueDataResult GetRevenueData();

        List<OrderResult> GetOrderList();

        List<TopProductResult> GetTopProductList();
    }
}
