using Application.Interfaces;
using Application.Services;
using Data.Repositories;
using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IPersonService, PersonService>();

            services.AddScoped<IPersonRepository, PersonRepository>();
        }
    }
}
