using System;

namespace GlobalX.AspNetCore.Hateoas.JsonApi.Core
{
    public static class DataExtensions
    {
        public static void Attributes(this Data data, Action<dynamic> attributes)
        {
            var value = new Attributes();
            attributes(value as dynamic);
            data.Attributes = value;
        }
    }
}