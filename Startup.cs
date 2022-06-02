using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Мarketplace.Data.Interfaces;
using Мarketplace.Data.Mocks;

namespace Мarketplace
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ISmartphoneCategory, MockCategory>();
            services.AddTransient<IAllSmartphones, MockSmartphones>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
           app.UseDeveloperExceptionPage();
           app.UseStatusCodePages();
           app.UseStaticFiles();
           app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name:"default","{controller=Home}/{action=Index}");
            });
        }
    }
}
