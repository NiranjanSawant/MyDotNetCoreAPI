using System.Net;
using System.Text.Json;

namespace WebAppTest1.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;

        public ExceptionMiddleware(RequestDelegate next,ILogger<ExceptionMiddleware> logger)
        {
            _next=next;
            _logger=logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
               await _next(context);
            }
            catch(Exception ex)
            {
                var correlationId = context.TraceIdentifier;
                _logger.LogError(ex, "Unhandled exception occurred. CorrelationId: {CorrelationId}, Path: {Path}",
                correlationId,
                context.Request.Path);

                await HandleException(context, correlationId);
            }
        }

        private static async Task HandleException(HttpContext context,string corelationID)
        {
            context.Response.ContentType = "";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var response = new
            {
                message="Unexpected error",
                corelationID
            };

            await context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }
    }
}
