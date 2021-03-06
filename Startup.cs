using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using HotelApi.Infra;
using HotelApi.Data;
using HotelApi.Config.Infra;

namespace hotel_api
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
			var mySQLSettings = Configuration.GetSection(nameof (MySQLSettings)).Get<MySQLSettings>();
			/* var testing = DatabaseConfig.GetDatabaseConnectionString(); */
			/* Console.WriteLine(DatabaseConfig.GetDatabaseConnectionString()); */
			/* string test = DatabaseConfig.Load("Host"); */
			/* Console.WriteLine(test); */

			services.AddDbContext<DatabaseContext>(options =>
				options.UseMySql(mySQLSettings.ConnectionString, ServerVersion.AutoDetect(mySQLSettings.ConnectionString))
			);

            services.AddControllers();
            services.AddCors(opt => {
				opt.AddPolicy("CorsPolicyAllowingAll", builder => 
					builder.AllowAnyOrigin()
					.AllowAnyMethod()
					.AllowAnyHeader()
				);
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "hotel_api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "hotel_api v1"));
            }

			app.UseCors("CorsPolicyAllowingAll");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
