﻿using Microsoft.EntityFrameworkCore;
using test.sql;

namespace EF8Perf810
{
    [TestClass]
    public class QueryTests
    {
        static tstTestDBContext CreateTestDBContext(string[] args = null) => new TestDbContextDesignFactory().CreateDbContext(Guid.Empty, args);

        tstTestDBContext Context
        {
            get
            {
                var ctx = CreateTestDBContext();
                ctx.Database.EnsureDeleted();
                ctx.Database.Migrate();
                return ctx;
            }
        }

        [TestMethod]
        public void HashSetQuery()
        {
            using (var ctx = Context)
            {
                var ids = new HashSet<Guid>() { Guid.NewGuid() };
                var items1 = ctx.Raws.Where(r => ids.Contains(r.Id)).ToList();
            }
        }

        [TestMethod]
        public void IdsContainerQuery()
        {
            using (var ctx = Context)
            {
                var idsContainer = new IdsContainer() { Guid.NewGuid() };
                var items2 = ctx.Raws.Where(r => idsContainer.Contains(r.Id)).ToList();
            }
        }

        [TestMethod]
        public void IdsContainerAndCollectionQuery()
        {
            using (var ctx = Context)
            {
                var idsContainer = new IdsContainerAndCollection() { Guid.NewGuid() };
                var items2 = ctx.Raws.Where(r => idsContainer.Contains(r.Id)).ToList();
            }
        }

        [TestMethod]
        public void IdsContainerAndExplicitCollectionQuery()
        {
            using (var ctx = Context)
            {
                var idsContainer = new IdsContainerAndExplicitCollection() { Guid.NewGuid() };
                var items2 = ctx.Raws.Where(r => idsContainer.Contains(r.Id)).ToList();
            }
        }


        [TestMethod]
        public void IdsContainerWithContainsQuery()
        {
            using (var ctx = Context)
            {
                var genericIdsContainer = new IdsContainerWithContains() { Guid.NewGuid() };
                var items3 = ctx.Raws.Where(r => genericIdsContainer.Contains(r.Id)).ToList();
            }
        }

        [TestMethod]
        public void BaseRefCollectionQuery()
        {
            using (var ctx = Context)
            {
                var refSet = new BaseRefCollection();
                refSet.Add(Guid.NewGuid());
                var items4 = ctx.Raws.Where(r => refSet.Contains(r.Id)).ToList();
            }
        }

        [TestMethod]
        public void GenericBaseRefCollectionQuery()
        {
            using (var ctx = Context)
            {
                // same class with generic arguments is not working
                var refSet = new GenericBaseRefCollection<HashSet<Guid>, IEntity>();
                refSet.Add(Guid.NewGuid());
                var items4 = ctx.Raws.Where(r => refSet.Contains(r.Id)).ToList();
            }
        }

        void ContainsInEnumerableWithOption(bool flag)
        {
            using (var ctx = Context)
            {
                var ids = flag ? ctx.Raws.Select(c => c.Id) : null;

                var items4 = ctx.Raws.Where(r => ids != null && ids.Contains(r.Id)).ToList();
            }
        }

        [TestMethod]
        public void HashSetContains()
        {
            using (var ctx = Context)
            {
                var refSet = new HashSet<Guid>();
                refSet.Add(Guid.NewGuid());

                //IEnumerable<IEntity> ir = refSet;
                var items4 = ctx.Raws.Where(r => refSet.Contains(r.Id)).ToList();
            }
        }

        [TestMethod]
        public void ContainsInEnumerable()
        {
            ContainsInEnumerableWithOption(true);
            ContainsInEnumerableWithOption(false);
        }
    }
}