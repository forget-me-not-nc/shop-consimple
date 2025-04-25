using Repository.Abstract;
using Repository.Concrete;

namespace ShopConsimple.Extensions
{
    public static class AddRepositoriesExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services) 
        {
            services.AddScoped<IOrderRepository, OrderRepository>(); 
            services.AddScoped<IClientRepository, ClientRepository>(); 

            return services;
        }
    }
}
