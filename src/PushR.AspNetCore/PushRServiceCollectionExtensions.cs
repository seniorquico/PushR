using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class PushRServiceCollectionExtensions
    {
        public static IServiceCollection AddPushR(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            return services;
        }
    }
}
