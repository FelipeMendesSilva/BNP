using BNP.CMM.Infra.IoC;

namespace BNP.CMM.API.IoC
{
    public static class RegisterServicesExtension
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterInfraServices(configuration);
            //services.AddScoped<IProdutoService, ProdutoService>();
            //services.AddScoped<IProdutoRepository, ProdutoRepository>();
        }
    }
}
