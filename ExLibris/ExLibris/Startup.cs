using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExLibris.Contracts.Constants.GeneralConstants;
using ExLibris.Contracts.Entities;
using ExLibris.Extensions;
using ExLibris.Infrastructure.AppContext.Persistance;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ExLibris
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString(GeneralApiConstants.Configuration_DbConnection)));

            services.AddIdentityCore<Person>(options =>
            {
                options.Tokens.PasswordResetTokenProvider = TokenOptions.DefaultEmailProvider;
                options.User.RequireUniqueEmail = true;
            })
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<AppDbContext>();

            services.ConfigureInfrastructureServices();

            services.AddControllers();

            services.ConfigureAuthentication(Configuration);

            services.ConfigureCors(Configuration);

            services.ConfigureSwagger(Configuration);

            services.ConfigureMapping();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseSwagger();

            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint(Configuration[GeneralApiConstants.Configuration_SwaggerEndpoint],
                    string.Concat(GeneralApiConstants.SwaggerApiTitle, " ", GeneralApiConstants.SwaggerApiVersion));
            });

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
