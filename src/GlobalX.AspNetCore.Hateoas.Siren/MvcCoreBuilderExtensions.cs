using System;
using GlobalX.AspNetCore.Hateoas.Siren.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

namespace GlobalX.AspNetCore.Hateoas.Siren
{
    public static class MvcCoreBuilderExtensions
    {
        public static IMvcCoreBuilder AddSirenOptions(this IMvcCoreBuilder builder, Action<SirenOptions> setupAction)
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            builder.Services.Configure(setupAction);
            return builder;
        }

        internal static void AddSirenFormatterServices(IServiceCollection services)
        {
            services.TryAddEnumerable(ServiceDescriptor
                .Transient<IConfigureOptions<SirenOptions>, SirenOptionsSetup>());
        }
    }
}