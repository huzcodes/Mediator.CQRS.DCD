using huzcodes.Extensions.Exceptions;
using Mediator.CQRS.Application.PipelineBehaviour;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Mediator.CQRS.Application
{
    public static class ApplicationRegistrations
    {
        public static void AddApplicationRegistrations(this IServiceCollection services)
        {
            services.AddMediatR(options => options.RegisterServicesFromAssembly(typeof(ApplicationRegistrations).Assembly));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPipeline<,>));
            services.AddFluentValidation(typeof(ApplicationRegistrations));
        }
    }
}
