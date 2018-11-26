using System.Collections.Generic;
using System.Linq;

namespace GlobalX.AspNetCore.Hateoas.Siren
{
    public static class Extensions
    {
        internal static bool Any<TSource>(this IEnumerable<TSource> source)
        {
            return null != source && Enumerable.Any(source);
        }
    }
}