namespace FraudDetection.Api.Config;

internal static class OpenApiConfiguration
{
    public static void ConfigureOpenApi(this IServiceCollection services) =>
        services.AddOpenApi(opt =>
        {
            opt.AddDocumentTransformer((doc, context, cancellationToken) =>
            {
                doc.Info.Title = "API.Fraud.Detection";
                doc.Info.Version = "v1";
                doc.Info.Description = "API that detects fraud in card transactions using vector search for each incoming transaction.";
                return Task.CompletedTask;
            });
        });
}