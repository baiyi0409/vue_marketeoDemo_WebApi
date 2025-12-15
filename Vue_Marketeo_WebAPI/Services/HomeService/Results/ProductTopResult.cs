using System.Reflection.Metadata.Ecma335;

namespace Vue_Marketeo_WebAPI.Services.HomeService.Results
{
    public class TopProductResult
    {
        public int Id { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string ImgUrl { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 销售数量
        /// </summary>
        public int SoldNum { get; set; }

        /// <summary>
        /// 产品价格
        /// </summary>
        public double Price { get; set; }
    }
}
