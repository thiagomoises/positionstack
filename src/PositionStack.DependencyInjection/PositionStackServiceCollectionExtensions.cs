using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PositionStack.Options;
using Refit;

namespace PositionStack.DependencyInjection
{
    public static class PositionStackServiceCollectionExtensions
    {
        public static IHttpClientBuilder AddPositionStackClient(this IServiceCollection services, IConfiguration configuration)
        {
            var positionStackOptions = configuration.GetSection(nameof(PositionStackOptions)).Get<PositionStackOptions>();
            services.Configure<PositionStackOptions>(
                configuration.GetSection(nameof(PositionStackOptions)));

            services.AddTransient<PositionStackHandler>();

            return services.AddRefitClient<IPositionStackClient>()
                .ConfigureHttpClient(c => c.BaseAddress = positionStackOptions.BaseAddress)
                .AddHttpMessageHandler<PositionStackHandler>();
        }
    }
}