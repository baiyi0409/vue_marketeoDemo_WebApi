namespace Vue_Marketeo_WebAPI.Common
{
    public class BaseApiResponse
    {
        public int code { get; set; } = 200;
        public object? data { get; set; }
        public string? message { get; set; }
    }
}
