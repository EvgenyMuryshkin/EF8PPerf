using System.Collections;

namespace EF8Perf810
{
    class IdsContainerAndExplicitCollection : IEnumerable<Guid>, ICollection<Guid>
    {
        HashSet<Guid> _ids = new HashSet<Guid>();

        public void Add(Guid item) => _ids.Add(item);

        int ICollection<Guid>.Count => _ids.Count;

        bool ICollection<Guid>.IsReadOnly => false;

        void ICollection<Guid>.Add(Guid item) => _ids.Add(item);

        void ICollection<Guid>.Clear() => _ids.Clear();

        bool ICollection<Guid>.Contains(Guid item) => _ids.Contains(item);

        void ICollection<Guid>.CopyTo(Guid[] array, int arrayIndex) => _ids.CopyTo(array, arrayIndex);

        IEnumerator<Guid> IEnumerable<Guid>.GetEnumerator() => _ids.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => _ids.GetEnumerator();

        bool ICollection<Guid>.Remove(Guid item) => _ids.Remove(item);
    }
}