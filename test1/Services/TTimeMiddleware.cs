using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using test1.Services;

namespace test1.Services
{
    public class TTimeMiddleware
    {
        private readonly RequestDelegate _next;

        public TTimeMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        
        public async Task InvokeAsync(HttpContext httpContext, ITime ttime)
        {
            
            httpContext.Response.ContentType = "text/html;charset=utf-8";
            await httpContext.Response.WriteAsync($" <p> Текущее время: {ttime.Time()}</p>");
            await _next(httpContext);
        }
    }
}