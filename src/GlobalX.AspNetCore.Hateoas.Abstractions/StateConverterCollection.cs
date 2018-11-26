using System;
using System.Collections.Generic;

namespace GlobalX.AspNetCore.Hateoas.Abstractions
{
    public class StateConverterCollection
    {
        public StateConverterCollection(IReadOnlyList<IStateConverter> items, int version)
        {
            Items = items ?? throw new ArgumentNullException(nameof(items));
            Version = version;
        }

        public IReadOnlyList<IStateConverter> Items { get; }

        public int Version { get; }
    }
}