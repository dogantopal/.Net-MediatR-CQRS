using Application.Products;
using Infrastructure.Concretes;
using Infrastructure.Contracts;
using Infrastructure.Helpers;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
            });

            services.AddMediatR(typeof(List.Handler).Assembly);

            services.AddTransient<IDataHelper, DataHelper>();
            services.AddTransient<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
