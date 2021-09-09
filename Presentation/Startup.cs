using Autofac;
using Data;
using IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Steeltoe.Discovery.Client;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hystrix.Dotnet.AspNetCore;
using Hystrix.Dotnet;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ServiceProcess;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using HealthChecks.UI.Client;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.OpenApi.Models;

namespace Presentation
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
            var connection = @"User ID=iponvtrcywdqab;Password=a66426060562a657822746990d5567a27b8b5b92bc9b45f23e65b9a1b40f7e7f;Host=ec2-52-0-67-144.compute-1.amazonaws.com;Port=5432;Database=dbpiensig3o05q;Pooling=true";
            //services.AddDbContext<SqlContext>(options => options.UseSqlServer(connection));
            services.AddDbContext<SqlContext>(options => options.UseNpgsql(connection));
            services.AddMemoryCache();
            services.AddDiscoveryClient(Configuration);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
           
            services.AddLogging();
            services.AddHystrix();
            services.Configure<HystrixOptions>(options => Configuration.GetSection("Hystrix").Bind(options));
            services.AddHealthChecks()
                           
                            //.AddUrlGroup(new Uri("https://localhost:8091/weatherforecast"), "Exemplo de API 1")
                            .AddUrlGroup(new Uri("https://localhost:8091/swagger"), "ProjetoExame");
            //services.AddHealthChecksUI().AddInMemoryStorage();
            services.AddHealthChecksUI(s =>
                            {
                                s.AddHealthCheckEndpoint("endpoint1", "https://localhost:8091/health");
                            })
                            .AddInMemoryStorage();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PoupaCerto", Version = "v1" });
                //c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());

            });
        }

     

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PoupaCerto API v1"));
            app.UseDiscoveryClient();
            app.UseHttpsRedirection();
            app.UseRouting();
            //app.UseAuthorization();
            app.MapWhen(context => context.Request.Method.Equals("options", StringComparison.OrdinalIgnoreCase), HandleHead);
            app.UseCors(options => options.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin());
      
            app.UseHystrixMetricsEndpoint("hystrix.stream");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHealthChecksUI();          

                endpoints.MapHealthChecks("/health", new HealthCheckOptions()
                {
                    Predicate = _ => true,
                    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
                });
                app.UseHealthChecksUI(setup =>
                {
                    setup.UIPath = "/healthchecks-ui"; // ui path
                    setup.ApiPath = "/health-ui-api"; // this is the internal ui api
                });
            });
        }

        public void ConfigureContainer(ContainerBuilder Builder)
        {
            Builder.RegisterModule(new ModuleIoC());
        }
     
        private static void HandleHead(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                context.Response.StatusCode = 200;
                await context.Response.WriteAsync($"Up to head!");
            });
        }
    }
}
