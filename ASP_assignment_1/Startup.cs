using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using asgn2.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace asgn2
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration conf)
        {
            Configuration = conf;
        }



        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration["Data:RecipeSystemRecipes:ConnectionString"])
            );



            services.AddTransient<IRecipeRepository,EFRecipeRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
         
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(
                routes =>
                {
                    routes.MapRoute(
                        name: "default",
                        template: "",
                        defaults: new { controller = "Home", action = "Index" }
                        );
                    
                    routes.MapRoute(
                        name: "product",
                        template: "{controller}/{action}/{id?}"

                        );


                }
                );
            SeedData.EnsurePopulated(app);

        }
    }
}
