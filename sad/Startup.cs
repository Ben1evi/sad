using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace sad
{
    public class Startup
    {

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseRouting();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "avtors",
                    pattern: "avtors",
                    defaults: new { controller = "Avtors", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "books",
                    pattern: "books",
                    defaults: new { controller = "Books", action = "Index" });

                endpoints.MapDefaultControllerRoute();
            });
        }

    }
}
