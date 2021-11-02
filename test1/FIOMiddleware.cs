using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using test1.Services;

namespace test1
{
    public class FIOMiddleware
    {
        private readonly RequestDelegate _next;

        public FIOMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        
        public async Task InvokeAsync(HttpContext httpContext, IFIO myfio)
        {
            
            
            await httpContext.Response.WriteAsync($" <p> Исполнитель: {myfio.FFIO }</p>");
            await _next(httpContext);
        }
    }
}