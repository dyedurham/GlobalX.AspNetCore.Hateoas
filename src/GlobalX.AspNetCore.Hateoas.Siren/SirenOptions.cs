using System.Collections.Generic;
using GlobalX.AspNetCore.Hateoas.Abstractions;

namespace GlobalX.AspNetCore.Hateoas.Siren
{
    public class SirenOptions
    {
        public SirenSerializerSettings SerializerSettings { get; } =
            SirenSerializerSettingsProvider.CreateSerializerSettings();

        public IList<IStateConverterProvider> StateConverters { get; } = new List<IStateConverterProvider>();
    }
}