using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MgenixMember.Domain.Interfaces;
using MgenixMember.Infrastructure.Data;
using MgenixMember.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MgenixMember.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped<DapperHelper>();
            services.AddScoped<IMemberRepository, MemberRepository>();

            return services;
        }
    }
}
