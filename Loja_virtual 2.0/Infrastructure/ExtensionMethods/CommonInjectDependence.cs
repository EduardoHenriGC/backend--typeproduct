using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LojaVirtual.Infrastructure.ExtensionMethods
{
    public static class CommonInjectDependence
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {

            
            services.AddTransient<Interfaces.IProductViewModelService, Services.ProductViewModelService>();


            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {

            
            services.AddTransient<Domain.Interfaces.IProductRepository, Data.Repositories.ProductRepository>();


            return services;
        }
    }
}
