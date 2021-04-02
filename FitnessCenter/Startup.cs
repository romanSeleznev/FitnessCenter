using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessCenter.Managers.CenterManager;
using FitnessCenter.Managers.ClientManager;
using FitnessCenter.Managers.RoomManager;
using FitnessCenter.Managers.TrenerManager;
using FitnessCenter.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace FitnessCenter
{
    public class Startup

    {
        private IConfigurationRoot _configurationRoot;
        public Startup(IHostingEnvironment hostingEnvironment)
        {
            // Configuration = configuration;
            _configurationRoot = new ConfigurationBuilder().SetBasePath(hostingEnvironment.ContentRootPath).AddJsonFile("jsconfig.json").Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            //services.AddDbContext<CenterContext>(options => options.UseSqlServer("Data Source=blog.db"));
            services.AddDbContext<CenterContext>(options => options.UseSqlServer(_configurationRoot.GetConnectionString("StudentDb")));
            services.AddMvc(option => option.EnableEndpointRouting = false);

            services.AddTransient<ICenterManager, CenterManager>();
            services.AddTransient<ITrenerManager, TrenerManager>();
            services.AddTransient<IClientManager, ClientManager>();
            services.AddTransient<IRoomManager, RoomManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
           
            
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Center}/{action=ShowCenter}/{id?}");
            });

        }
    }
}
