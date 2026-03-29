using MgenixMember.Application;
using MgenixMember.Infrastructure;

namespace MgenixMember.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAPI(
        this IServiceCollection services,
        IConfiguration configuration)
        {
            services.AddApplication();
            services.AddInfrastructure(configuration);

            return services;
        }
    }
}
