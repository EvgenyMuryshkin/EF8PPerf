using crosscutting.sql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;
using System;
using System.Diagnostics;

namespace test.sql
{
    public class TestDbContextDesignFactory : AbstractContextDesignFactory<tstTestDBContext>
    {
        public static string ConnectionString = "Data Source=.\\;Initial catalog=test;Integrated Security=False;User ID=scms;Password=scms;";
        public override tstTestDBContext CreateDbContext(Guid platformId, params string[] args)
            => InternalCreateDbContext(
                platformId,
                ConnectionString,
                tstTestDBContext.SchemaName,
                args);
    }
}
