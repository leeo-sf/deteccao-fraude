using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Options;

namespace FraudDetection.Ioc;

public class ConfigureKestrelOptions : IConfigureOptions<KestrelServerOptions>
{
    public void Configure(KestrelServerOptions options)
    {
        options.AddServerHeader = false;

        options.Limits.MaxConcurrentConnections = 100;
        options.Limits.MaxRequestBodySize = 5 * 1024;

        options.Limits.RequestHeadersTimeout = TimeSpan.FromSeconds(1);
        options.Limits.KeepAliveTimeout = TimeSpan.FromSeconds(20);
    }
}