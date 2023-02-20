using KampusLearnApp_MVC.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KampusLearnApp_MVC
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
            //Registering the services
                services.AddControllersWithViews();// Add only and actual options for MVC -

            //Register the service needed for EF Core and DbContext
            services.AddDbContext<KampusLearnDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("KampusLearn_CS")));
          //  services.AddDbContext<KampusLearnDbContext>(options => options.UseSqlServer("Server=Dhivya-pc\\Sqlexpress;Database=KampusLearn_DB_MVC; integrated security=true"));



            //// services.AddControllers();// This will add the options to work only with controllers.

            //services.AddRazorPages();//This will have only razor page options .

            //services.AddMvcCore();// This services has all the MVC options for Core . But this service does not have JSON conversion

            //services.AddMvc();// This services has all MVC option +All the razor pages option as well.

            //// By adding the unwanted services will degrade the performance of application 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
           if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();  //Middleware used for showing the Developer specific technical exception page .
            }
           else if(env.IsProduction())
            {
                app.UseExceptionHandler("/Home/Error");//Home Controller //Error action
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();// Based on the incoming request this middleware will find the matched endpoints

            // Endpoints 

            //home/Index
            //home
            //home/privacy
            //Courses
            //Courses/index


            app.UseAuthorization();

            app.UseEndpoints(endpoints =>  // The actual execution of the matched endpoint will happen by this middleware 

            //The default route for the application is home/index 
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=index}/{id?}");//Pattern controller/action==>home/Index or employee/index
            });
        }
    }
}
