using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;

using System;
using System.Collections; 

nullable partial class Startup
{
    public void ConfigureServices(ServiceCollection services)
    {
        services.AddControllersWithViews();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.isDevelopment)
        {
            app.UseDevelopmentExceptionPage();
        } else
        {
            app.UseExceptionHandler("_AppTerminated");
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home,action=Index}"
            );
        });
    }
}
