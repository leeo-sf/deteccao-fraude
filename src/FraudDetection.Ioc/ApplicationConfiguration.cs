using FraudDetection.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace FraudDetection.Ioc;

public static class ApplicationConfiguration
{
    public static void ConfigureMediatr(this IServiceCollection services) =>
        services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(DomainAssembly).Assembly));
}