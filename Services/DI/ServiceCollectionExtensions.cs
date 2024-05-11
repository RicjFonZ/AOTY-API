using DataAccess.Repositories;
using DataAccess.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Models;

namespace Services.DI
{
    /// <summary>
    /// ServiceCollectionExtensions
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the business services.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns></returns>
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ApplicationAutoMapperProfile).Assembly);
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            
            return services;
        }
    }
}