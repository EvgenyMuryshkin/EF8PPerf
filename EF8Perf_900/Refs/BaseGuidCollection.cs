namespace EF8Perf900
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class BaseGuidCollection<T> : IEnumerable<T>, ICollection<T>
    {
        protected HashSet<T> _container = new();

        public BaseGuidCollection()
        {
        }

        public int Count => ((ICollection<T>)_container).Count;

        public bool IsReadOnly => ((ICollection<T>)_container).IsReadOnly;

        public void Add(T id) => _container.Add(id);

        public void Clear()
        {
            ((ICollection<T>)_container).Clear();
        }

        public bool Contains(T id) => _container.Contains(id);

        public void CopyTo(T[] array, int arrayIndex)
        {
            ((ICollection<T>)_container).CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            return ((ICollection<T>)_container).Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator() => _container.GetEnumerator();
        IEnumerator<T> IEnumerable<T>.GetEnumerator() => _container.GetEnumerator();
    }
}
