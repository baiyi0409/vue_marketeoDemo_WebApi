using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Vue_Marketeo_WebAPI.Common
{
    public class ResponseAttribute : ResultFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            if (context.Result is ObjectResult objectResult && objectResult.Value != null)
            {
                var wrapped = new BaseApiResponse
                {
                    code = objectResult.StatusCode ?? 200,
                    data = objectResult.Value
                };

                context.Result = new ObjectResult(wrapped)
                {
                    StatusCode = objectResult.StatusCode
                };
            }

            base.OnResultExecuting(context);
        }
    }
}
