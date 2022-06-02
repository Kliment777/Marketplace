using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Мarketplace.Data.Db;
using Мarketplace.Data.Interfaces;
using Мarketplace.Data.Mocks;
using Мarketplace.Data.Repository;

namespace Мarketplace
{
    public class Startup
    {
        private IConfigurationRoot _confstring;
        public Startup(IWebHostEnvironment hostEnv) 
        {
            _confstring = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confstring.GetConnectionString("DefaultConnection")));
            /*services.AddTransient<ISmartphoneCategory, MockCategory>();
            services.AddTransient<IAllSmartphones, MockSmartphones>();*/
            services.AddTransient<IAllSmartphones, SmatphoneRepository>();
            services.AddTransient<ISmartphoneCategory, CategoryRepository>();
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
