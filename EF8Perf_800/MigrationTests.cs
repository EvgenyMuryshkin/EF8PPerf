using Microsoft.EntityFrameworkCore;
using test.sql;

namespace EF8Perf800
{
    [TestClass]
    public class MigrationTests
    {
        static tstTestDBContext CreateTestDBContext(string[] args = null) => new TestDbContextDesignFactory().CreateDbContext(Guid.Empty, args);

        [TestMethod]
        public async Task MigrateAsync()
        {
            using (var ctx = CreateTestDBContext())
            {
                await ctx.Database.EnsureDeletedAsync();

                await ctx.Database.MigrateAsync();
            }
        }
    }
}