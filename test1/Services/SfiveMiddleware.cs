using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using test1.Services;

namespace test1.Services
{
    public class SfiveMiddleware
    {
        private readonly RequestDelegate _next;

        public SfiveMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        
        public async Task InvokeAsync(HttpContext httpContext, I5 ss5)
        {
            
            
            await httpContext.Response.WriteAsync($" <p>  {ss5.Five()}</p>");
            await _next(httpContext);
        }
    }
}