using System.Collections.Generic;
using GlobalX.AspNetCore.Hateoas.Abstractions;

namespace GlobalX.AspNetCore.Hateoas.JsonApi
{
    public class JsonApiOptions
    {
        public IList<IStateConverterProvider> Converters { get; } = new List<IStateConverterProvider>();
    }
}