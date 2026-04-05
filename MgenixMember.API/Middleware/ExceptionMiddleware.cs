using System.Net;
using System.Text.Json;
using MgenixMember.Application.Common;

namespace MgenixMember.API.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleException(context, ex);
            }
        }

        private static async Task HandleException(HttpContext context, Exception ex)
        {
            var response = context.Response;
            response.ContentType = "application/json";

            var apiResponse = new ApiResponse<string>(
                message: ex.Message,
                statusCode: (int)HttpStatusCode.InternalServerError
            );

            response.StatusCode = apiResponse.StatusCode;

            var result = JsonSerializer.Serialize(apiResponse);

            await response.WriteAsync(result);
        }
    }
}
