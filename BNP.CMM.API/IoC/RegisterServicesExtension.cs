using BNP.CMM.Application.AutoMapper;
using BNP.CMM.Application.Requests;
using BNP.CMM.Application.Validators;
using BNP.CMM.Infra.IoC;
using FluentValidation;
using System;

namespace BNP.CMM.API.IoC
{
    public static class RegisterServicesExtension
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterInfraServices(configuration);
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddMediatR(cfg =>
                cfg.RegisterServicesFromAssembly(typeof(GetProductsRequest).Assembly));
        }
    }
}
