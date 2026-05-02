using FraudDetection.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace FraudDetection.Ioc;

public static class ApplicationConfiguration
{
    private const string DATASET_FOLDER = "dataset";
    private const string FILE_NORMALIZATION = "normalization.json";
    private const string FILE_MCC_RISK = "mcc_risk.json";

    public static void ConfigureMediatr(this IServiceCollection services) =>
        services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(DomainAssembly).Assembly));

    public static void AddFraudConfiguration(this IServiceCollection services)
    {
        var rootPath = Path.Combine(AppContext.BaseDirectory, DATASET_FOLDER);

        var normalizationPath = Path.Combine(rootPath, FILE_NORMALIZATION);
    }
}