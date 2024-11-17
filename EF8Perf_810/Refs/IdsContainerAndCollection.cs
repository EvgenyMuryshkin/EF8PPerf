using System.Collections;

namespace EF8Perf810
{
    class IdsContainerAndCollection : IEnumerable<Guid>, ICollection<Guid>
    {
        HashSet<Guid> _ids = new HashSet<Guid>();

        public int Count => _ids.Count;

        public bool IsReadOnly => false;

        public void Add(Guid id)
        {
            _ids.Add(id);
        }

        public void Clear() => _ids.Clear();

        public bool Contains(Guid item) => _ids.Contains(item);

        public void CopyTo(Guid[] array, int arrayIndex) => _ids.CopyTo(array, arrayIndex);

        public bool Remove(Guid item) => _ids.Remove(item);

        public IEnumerator<Guid> GetEnumerator() => _ids.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _ids.GetEnumerator();
    }
}