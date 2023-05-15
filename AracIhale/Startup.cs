
using AracIhale.UI;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhale
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScoped<APIGateway>();
            services.AddHttpContextAccessor();
			services.AddDistributedMemoryCache(); // MemoryCache hizmetini ekliyoruz.
			services.AddSession(options =>
			{
				options.IdleTimeout = TimeSpan.FromMinutes(30); // Oturum s�resini 30 dakika olarak belirliyoruz.
				options.Cookie.HttpOnly = true;
				options.Cookie.IsEssential = true;
			});


			services.AddHttpClient();
           
            
            services.AddAuthentication("CookieAuthentication")
        .AddCookie("CookieAuthentication", config =>
        {
            config.Cookie.Name = "UserLoginCookie";
            config.LoginPath = "/Login/Login";
        });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseSession();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Login}/{id?}");
            });
        }
    }
}
