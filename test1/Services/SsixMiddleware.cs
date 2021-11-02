using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using test1.Services;

namespace test1.Services
{
    public class SsixMiddleware
    {
        private readonly RequestDelegate _next;

        public SsixMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        
        public async Task InvokeAsync(HttpContext httpContext, I6 ss6)
        {
            
            
            await httpContext.Response.WriteAsync($" <p>  {ss6.Six()}</p>");
            await _next(httpContext);
        }
    }
}