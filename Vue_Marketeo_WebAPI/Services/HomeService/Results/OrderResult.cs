namespace Vue_Marketeo_WebAPI.Services.HomeService.Results
{
    public class OrderResult
    {
        public int Id { get; set; }

        /// <summary>
        /// 产品图片
        /// </summary>
        public string ImgUrl { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 订单日期
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// 客户
        /// </summary>
        public string Customer { get; set; }
    }

    public enum OrderStatus
    {
        Received,
    }
}
