using Mediator.CQRS.Core.Interfaces;
using Mediator.CQRS.Services.User;
using Microsoft.Extensions.DependencyInjection;

namespace Mediator.CQRS.Services
{
    public static class ServicesRegistrations
    {
        public static void AddServicesRegistrations(this IServiceCollection services)
        {
            services.AddScoped<IUserServices, UserServices>();
        }
    }
}
