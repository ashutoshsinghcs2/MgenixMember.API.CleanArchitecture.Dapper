using MgenixMember.API.Services;
using MgenixMember.Application;
using MgenixMember.Application.Common;
using MgenixMember.Infrastructure;
using Serilog;

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

            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.Console()
            .WriteTo.File(
                path: "Logs/log-.txt",
                rollingInterval: RollingInterval.Day,
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] {Message}{NewLine}{Exception}"
            )
            .CreateLogger();

            return services;
        }
    }
}
