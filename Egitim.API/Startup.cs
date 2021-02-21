using Egitim.Business.Abstract;
using Egitim.Business.Concrete;
using Egitim.DataAccess.Abstract;
using Egitim.DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Egitim.API
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
            services.AddControllers();
            services.AddDbContext<EgitimDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), c => c.MigrationsAssembly("Egitim.DataAccess")));
            services.AddMvc().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

            services.AddTransient<IOgretmenService, OgretmenManager>();
            services.AddTransient<IOgretmenDal, OgretmenDal>();

            services.AddTransient<IOkulService, OkulManager>();
            services.AddTransient<IOkulDal, OkulDal>();

            services.AddTransient<IOkulYorumService, OkulYorumManager>();
            services.AddTransient<IOkulYorumDal, OkulYorumDal>();

            services.AddTransient<IOgretmenYorumService, OgretmenYorumManager>();
            services.AddTransient<IOgretmenYorumDal, OgretmenYorumDal>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseCors(c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
