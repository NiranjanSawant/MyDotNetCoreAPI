namespace WebAppTest1.Middlewares
{
    public class CorelationIdMiddleware
    {
        private const string HeaderName = "X-Correlation-Id";
        private readonly RequestDelegate _next;

        public CorelationIdMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var correlationid = context.Request.Headers.ContainsKey(HeaderName) ? context.Request.Headers[HeaderName].ToString()
            : Guid.NewGuid().ToString();

            context.TraceIdentifier = correlationid;

            context.Response.OnStarting(() =>
            {
                context.Response.Headers[HeaderName] = correlationid;
                return Task.CompletedTask;
            });

            await _next(context);
        }
    }
}
