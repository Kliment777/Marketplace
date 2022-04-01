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
            services.AddTransient<IAllSmartphones, MockSmartphone>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
           app.UseDeveloperExceptionPage();
           app.UseStatusCodePages();
           app.UseStaticFiles();
           app.UseRouting();
        }
    }
}
