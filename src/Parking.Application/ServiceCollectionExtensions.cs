using Microsoft.Extensions.DependencyInjection;
using Parking.Application;
using Parking.Application.Interface;

namespace Parking.Domain
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IParkingAppService, ParkingAppService>();
            services.AddTransient<ICarAppService, CarAppService>();

            return services;
        }
    }
}
