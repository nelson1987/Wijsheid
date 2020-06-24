using Microsoft.Extensions.DependencyInjection;
using Wijsheid.Application.Contracts.Interfaces;
using Wijsheid.Application.Services;
using Wijsheid.Repository.Contracts.Interfaces;
using Wijsheid.Repository.Repositories;
using Wijsheid.Service.Contracts.Interfaces;
using Wijsheid.Service.Services;

namespace Wijsheid.Crosscutting
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddInjections(this IServiceCollection services)
        {
            services.AddScoped<IAlunoApplicationService, AlunoApplicationService>();
            services.AddScoped<IAlunoService, AlunoService>();
            services.AddScoped<IAlunoRepository, AlunoRepository>();
            return services;
        }
    }
}
