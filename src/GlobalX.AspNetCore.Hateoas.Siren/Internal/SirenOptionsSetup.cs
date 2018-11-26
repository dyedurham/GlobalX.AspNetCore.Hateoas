using System.Buffers;
using GlobalX.AspNetCore.Hateoas.Siren.Converters;
using Microsoft.Extensions.ObjectPool;
using Microsoft.Extensions.Options;

namespace GlobalX.AspNetCore.Hateoas.Siren.Internal
{
    public class SirenOptionsSetup : ConfigureOptions<SirenOptions>
    {
        public SirenOptionsSetup(ArrayPool<char> charPool, ObjectPoolProvider objectPoolProvider)
            : base(options => ConfigureSiren(options, options.SerializerSettings, charPool, objectPoolProvider))
        {
        }

        public static void ConfigureSiren(SirenOptions sirenOptions, SirenSerializerSettings serializerSettings,
            ArrayPool<char> charPool, ObjectPoolProvider objectPoolProvider)
        {
            serializerSettings.Converters.Add(new HrefJsonConverter());
            serializerSettings.ContractResolver = new SirenCamelCasePropertyNamesContractResolver();
        }
    }
}