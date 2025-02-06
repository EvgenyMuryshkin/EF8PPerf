namespace EF8Perf900
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class GenericBaseRefCollection<TEntity> : GenericBaseRefCollection<Guid, TEntity, HashSet<Guid>>
        where TEntity : IEntity
    { 
    }

    
    public class GenericBaseRefCollection<TArg, TEntity, T> : IEnumerable<Guid>, ICollection<Guid>
        where TArg : struct
        where TEntity : IEntity
        where T : ICollection<Guid>, new()
    {
        protected HashSet<Guid> _container = new();

        public GenericBaseRefCollection()
        {
        }

        public void Add(Guid id) => _container.Add(id);

        public bool Contains(Guid id) => _container.Contains(id);

        IEnumerator IEnumerable.GetEnumerator() => _container.GetEnumerator();
        IEnumerator<Guid> IEnumerable<Guid>.GetEnumerator() => _container.GetEnumerator();


        int ICollection<Guid>.Count => _container.Count;

        bool ICollection<Guid>.IsReadOnly => false;


        void ICollection<Guid>.Add(Guid item) => _container.Add(item);

        void ICollection<Guid>.Clear() => _container.Clear();

        bool ICollection<Guid>.Contains(Guid item) => _container.Contains(item);

        void ICollection<Guid>.CopyTo(Guid[] array, int arrayIndex) => _container.CopyTo(array, arrayIndex);

        bool ICollection<Guid>.Remove(Guid item) => _container.Remove(item);
    }
}
