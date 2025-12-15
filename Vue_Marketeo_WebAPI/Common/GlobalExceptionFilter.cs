using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Vue_Marketeo_WebAPI.Common
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is ApiException apiEx)
            {
                var response = new BaseApiResponse
                {
                    code = apiEx.StatusCode,
                    message = apiEx.ErrorMessage,
                    data = null
                };

                context.Result = new ObjectResult(response)
                {
                    //StatusCode = apiEx.StatusCode
                };

                context.ExceptionHandled = true;
            }
        }

        public class ApiException : Exception
        {
            public int StatusCode { get; }
            public string ErrorMessage { get; }

            public ApiException(int statusCode, string message) : base(message)
            {
                StatusCode = statusCode;
                ErrorMessage = message;
            }
        }
    }
}
