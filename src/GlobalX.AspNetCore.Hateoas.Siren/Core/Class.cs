using System.Collections.Generic;

namespace GlobalX.AspNetCore.Hateoas.Siren.Core
{
    public class Class : List<string>
    {
        public static implicit operator Class(string value)
        {
            return new Class {value};
        }
    }
}