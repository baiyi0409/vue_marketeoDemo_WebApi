namespace Vue_Marketeo_WebAPI.Services.HomeService.Results
{
    public class RevenueDataResult
    {
        /// <summary>
        /// 总收入
        /// </summary>
        public double TotalRevenue { get; set; }

        /// <summary>
        /// 总收入增长百分比
        /// </summary>
        public double TotalPercentage { get; set; }

        /// <summary>
        /// 收入维度类型
        /// </summary>
        public RevenueType Type { get; set; }

        /// <summary>
        /// 维度收入
        /// </summary>
        public double Revenue { get; set; }
    }

    public enum RevenueType 
    {
        Yearly,
        Quarterly,
        Monthly,
        Weekly,
        Daily
    }
}
