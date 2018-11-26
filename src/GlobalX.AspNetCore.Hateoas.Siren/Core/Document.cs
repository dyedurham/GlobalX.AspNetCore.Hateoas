using System.Reflection;

namespace GlobalX.AspNetCore.Hateoas.Siren.Core
{
    public class Document
    {
        public virtual Class Class { get; set; } = new Class();

        public object Properties { get; set; }

        public Entities Entities { get; set; } = new Entities();

        public Links Links { get; set; } = new Links();

        public Actions Actions { get; set; } = new Actions();

        public Rel Rel { get; set; }

        public Href Href { get; set; }
    }

    public class Document<T> : Document
    {
        public override Class Class { get; set; } = typeof(T).GetTypeInfo().Name;
    }
}