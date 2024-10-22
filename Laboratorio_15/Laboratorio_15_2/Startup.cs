namespace Laboratorio_15_2
{

    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.http;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Threading.Tasks;



    namespace Laboratorio_15_2
    {
        public class Startup
        {
            public void ConfigureServices(IServiceColllection services)
            {
            }

            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }
                app.UseRouting();
                app.UseEndPoints(endpoints =>
                {
                    endpoints.MapGet("/", async context =>
                    {
                        await context.Response.WriteAsync("Hellow Wolrd");
                    });
                });
            }
        }
    }
}
