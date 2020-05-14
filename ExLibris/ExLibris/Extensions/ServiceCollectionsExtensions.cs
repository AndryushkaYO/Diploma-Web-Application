using ExLibris.Contracts.Constants.GeneralConstants;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ExLibris.Extensions
{
    public static class ServiceCollectionsExtensions
    {
        public static void ConfigureInfrastructureServices(this IServiceCollection services)
        {
            throw new NotImplementedException();
        }

        public static void ConfigureAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            throw new NotImplementedException();
        }

        public static void ConfigureCors(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCors(o => o.AddPolicy(configuration[GeneralApiConstants.Configuration_Policy],
                builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                }));
        }

        public static void ConfigureSwagger(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(configuration[GeneralApiConstants.Configuration_SwaggerDoc],
                            new OpenApiInfo
                            {
                                Title = GeneralApiConstants.SwaggerApiTitle,
                                Version = GeneralApiConstants.SwaggerApiVersion
                            });

                var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlCommentsFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);

                c.IncludeXmlComments(xmlCommentsFullPath);

                c.AddSecurityDefinition(GeneralApiConstants.Bearer, new OpenApiSecurityScheme
                {
                    Description = GeneralApiConstants.SwaggerApiSecuritySchemeDescription,
                    Name = GeneralApiConstants.SwaggerApiSecuritySchemeName,
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = GeneralApiConstants.Bearer
                            },
                            Scheme = GeneralApiConstants.SwaggerApiSecurityScheme,
                            Name = GeneralApiConstants.Bearer,
                            In = ParameterLocation.Header,

                        },
                        new List<string>()
                    }
                });
            });
        }

        public static void ConfigureMapping(this IServiceCollection services)
        {
            throw new NotImplementedException();
        }

        public static void ConfigureHangFire(this IServiceCollection services, IConfiguration configuration)
        {
            throw new NotImplementedException();
        }
    }
}
