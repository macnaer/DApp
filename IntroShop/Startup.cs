using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroShop.Main;
using IntroShop.Main.Interfaces;
using IntroShop.Main.MockData;
using IntroShop.Main.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IntroShop
{
    public class Startup
    {
        private IConfigurationRoot _dbConf;
        public Startup(IHostingEnvironment ENV)
        {
            _dbConf = new ConfigurationBuilder().SetBasePath(ENV.ContentRootPath).AddJsonFile("settings.json").Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DBContent>(options => options.UseSqlServer(_dbConf.GetConnectionString("DefaultConnection")));
            //services.AddTransient<IAllPhones, MockPhones>();
            //services.AddTransient<IPhoneCategory, MockCategory>();
            services.AddTransient<IAllPhones, PhoneRepository>();
            services.AddTransient<IPhoneCategory, CategoryRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

           
            using (var scope = app.ApplicationServices.CreateScope())
            {
                DBContent content = scope.ServiceProvider.GetRequiredService<DBContent>();
                DBObjects.Initial(content);
            }
        }
    }
}
