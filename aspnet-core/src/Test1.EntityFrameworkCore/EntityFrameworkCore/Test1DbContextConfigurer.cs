using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Test1.EntityFrameworkCore
{
    public static class Test1DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<Test1DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<Test1DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
