using BNP.CMM.Domain.Interfaces;
using BNP.CMM.Infra.Context;
using BNP.CMM.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BNP.CMM.Infra.IoC
{
    public static class RegisterInfraServicesExtension
    {
        public static void RegisterInfraServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Exemplo de injeção de dependência
            services.AddScoped<IManualMovementsRepository, ManualMovementsRepository>();
            var connectionString = configuration.GetConnectionString("PostgresConnection");

            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(connectionString));
        }
    }
}
