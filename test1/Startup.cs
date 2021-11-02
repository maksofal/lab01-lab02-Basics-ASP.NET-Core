using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using test1.Services;

namespace test1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IFIO, FIO>();
            services.AddTransient<ICounter, Counter>();
            services.AddSingleton<IDate, GetDate>();
            
            services.AddScoped<ITime, GetTime>();
            services.AddTransient<I5, GetFIVE>();
            services.AddTransient<I6, GetSix >();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {

            app.Map("/index", Index);
            app.Map("/about", About);
            
 
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Page Not Found");
            });
            
        }
        private static void Index(IApplicationBuilder app)
        {
            app.UseMiddleware<CounterMiddleware>();
            app.UseMiddleware<FIOMiddleware>();
            app.UseMiddleware<DateMiddleware>();
            
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Index");
            });
        }
        private static void About(IApplicationBuilder app)
        {
            app.UseMiddleware<TTimeMiddleware>();
            app.UseMiddleware<SfiveMiddleware>();
            app.UseMiddleware<SsixMiddleware>();
            
            app.Run(async context =>
            {
                await context.Response.WriteAsync("About");
            });
        }
    }
}