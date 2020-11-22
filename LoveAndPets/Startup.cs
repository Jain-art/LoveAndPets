using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoveAndPets.Domain.DB;
using LoveAndPets.Domain.Model.Common;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AnimalDbContext = LoveAndPets.Domain.DB.AnimalDbContext;
using Microsoft.EntityFrameworkCore.Design;
using LoveAndPets.Infrastructure;
using LoveAndPets.Infrastructure.Guarantors;
using LoveAndPets.Infrastructure.Guarantiors;

namespace LoveAndPets
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
            services.AddDbContext<AnimalDbContext>(options =>
<<<<<<< HEAD
                options.UseNpgsql("Server=127.0.0.1;Port=5432;User Id=postgres;Password=coraline13;Database=LoveAndPets;"));
=======
                options.UseNpgsql("Server=127.0.0.1;Port=5432;User Id=postgres;Password=1234;Database=LoveAndPets;"));
>>>>>>> a67234ef46a3b6ee2f739398c8a60f24099773bc

            services.AddControllersWithViews();

            
            services.AddIdentity<User, IdentityRole<int>>(options =>
            {
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;

            }).AddEntityFrameworkStores<AnimalDbContext>();

            var sevisceProvider = services.BuildServiceProvider();
            var guarantor = new SeedDataGuarantor(sevisceProvider);
            guarantor.EnsureAsync();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var guarantors = scope.ServiceProvider.GetServices<IStartupPreConditionGuarantor>();
                try
                {
                    Console.WriteLine("Startup guarantors sterted");
                    foreach (var guarantor in guarantors)

                        guarantor.Ensure(scope.ServiceProvider);

                    Console.WriteLine("Startup guarantors executed successful");
                }
                catch (StartupPreConditionException)
                {
                    Console.WriteLine("Startup guarators failed");
                    throw;
                }

            }
            //app.UseRouting();
            //app.UseAuthentication();
            //app.UseAuthorization();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
