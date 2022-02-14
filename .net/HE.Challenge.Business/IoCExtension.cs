using Microsoft.Extensions.DependencyInjection;

namespace HE.Challenge.Business
{
    public static class IoCExtension
    {
        public static IServiceCollection BindBusiness(this IServiceCollection services)
        {
            services.AddScoped<INumberCalculator, NumberCalculator>();
            return services;
        }
    }
}
