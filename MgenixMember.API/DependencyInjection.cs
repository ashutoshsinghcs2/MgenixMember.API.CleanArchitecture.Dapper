using MgenixMember.API.Services;
using MgenixMember.Application;
using MgenixMember.Application.Common;
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

            services.AddHttpContextAccessor();
            services.AddScoped<ICurrentUserService, CurrentUserService>();

            return services;
        }
    }
}
