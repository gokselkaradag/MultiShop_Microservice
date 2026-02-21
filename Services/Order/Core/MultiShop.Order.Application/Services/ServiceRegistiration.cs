using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MultiShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers;

namespace MultiShop.Order.Application.Services;

public static class ServiceRegistiration
{
    //Bu yapı ilgili kütüphanemizin Registiration işlemini gerçekleştiriyor, program.cs de her seferinde mediatR çağırmak zorunda değiliz.
    
    public static void AddApplicationService(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServiceRegistiration).Assembly));
    }
}