using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using test1.Services;

namespace test1
{
    public class DateMiddleware
    {
        private readonly RequestDelegate _next;

        public DateMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        
        public async Task InvokeAsync(HttpContext httpContext, IDate myDate)
        {
            
            
            await httpContext.Response.WriteAsync($" <p> Текущая дата: {myDate.Ddate }</p>");
            await _next(httpContext);
        }
    }
}