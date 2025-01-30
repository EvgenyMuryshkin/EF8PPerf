namespace EF8Perf900
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class GenericBaseRefCollection<TArg, TEntity, T> : IEnumerable<TArg>, ICollection<TArg>
        where TArg : struct
        where TEntity : IEntity
        where T : ICollection<TArg>, new()
    {
        protected HashSet<TArg> _container = new();

        public GenericBaseRefCollection()
        {
        }

        public void Add(TArg id) => _container.Add(id);

        public bool Contains(TArg id) => _container.Contains(id);

        IEnumerator IEnumerable.GetEnumerator() => _container.GetEnumerator();
        IEnumerator<TArg> IEnumerable<TArg>.GetEnumerator() => _container.GetEnumerator();


        int ICollection<TArg>.Count => _container.Count;

        bool ICollection<TArg>.IsReadOnly => false;


        void ICollection<TArg>.Add(TArg item) => _container.Add(item);

        void ICollection<TArg>.Clear() => _container.Clear();

        bool ICollection<TArg>.Contains(TArg item) => _container.Contains(item);

        void ICollection<TArg>.CopyTo(TArg[] array, int arrayIndex) => _container.CopyTo(array, arrayIndex);

        bool ICollection<TArg>.Remove(TArg item) => _container.Remove(item);
    }
}
