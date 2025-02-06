namespace EF8Perf900
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class HashSetGuidCollection<TEntity> : AbstractEntityCollection<TEntity>
        where TEntity : class
    {
        public HashSetGuidCollection()
        {
            _container = new HashSet<Guid>(); // create an instance of collection on top-level class instead of passing as generic arg
        }
    }

    public class ListGuidCollection<TEntity> : AbstractEntityCollection<TEntity>
        where TEntity : class
    {
        public ListGuidCollection()
        {
            _container = new List<Guid>(); // create an instance of collection on top-level class instead of passing as generic arg
        }
    }

    public abstract class AbstractEntityCollection<TEntity> : AbstractGuidCollection
        where TEntity : class
    {

    }

    public abstract class AbstractGuidCollection : ICollection<Guid>
    {
        protected ICollection<Guid> _container;

        public int Count => _container.Count;

        public bool IsReadOnly => _container.IsReadOnly;

        public void Add(Guid item)
        {
            _container.Add(item);
        }

        public void Clear()
        {
            _container.Clear();
        }

        public bool Contains(Guid item)
        {
            return _container.Contains(item);
        }

        public void CopyTo(Guid[] array, int arrayIndex)
        {
            _container.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Guid> GetEnumerator()
        {
            return _container.GetEnumerator();
        }

        public bool Remove(Guid item)
        {
            return _container.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_container).GetEnumerator();
        }
    }
}
