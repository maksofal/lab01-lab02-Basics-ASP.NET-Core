using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using test1.Services;

namespace test1
{
    public class CounterMiddleware
    {
        private readonly RequestDelegate _next;
        public CounterMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        
        public async Task InvokeAsync(HttpContext httpContext, ICounter counter)
        {
            
            httpContext.Response.ContentType = "text/html;charset=utf-8";
            await httpContext.Response.WriteAsync($" <p> Количество запусков: {counter.Value}</p>");
            await _next(httpContext); //сделать чтоб шел дальше по конвееру
        }
    }
}