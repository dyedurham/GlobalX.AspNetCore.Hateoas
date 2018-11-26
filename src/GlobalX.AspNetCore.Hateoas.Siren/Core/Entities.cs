using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GlobalX.AspNetCore.Hateoas.Siren.Core
{
    public class Entities : IEnumerable<Entity>
    {
        private readonly List<Entity> _collection;

        public Entities(IEnumerable<Entity> collection = null)
        {
            _collection = new List<Entity>(collection ?? Enumerable.Empty<Entity>());
        }

        public IEnumerator<Entity> GetEnumerator()
        {
            return _collection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Entities Add(IEnumerable<Entity> collection)
        {
            _collection.AddRange(collection);
            return this;
        }

        public Entities Add(Entity item)
        {
            _collection.Add(item);
            return this;
        }
    }
}