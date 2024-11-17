using System.Collections;

namespace EF8Perf810
{
    class IdsContainer : IEnumerable<Guid>
    {
        HashSet<Guid> _ids = new HashSet<Guid>();

        public void Add(Guid id)
        {
            _ids.Add(id);
        }

        public IEnumerator<Guid> GetEnumerator() => _ids.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _ids.GetEnumerator();
    }
}