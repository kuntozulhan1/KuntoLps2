using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace KuntoLps2.EntityFrameworkCore
{
    public static class KuntoLps2DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<KuntoLps2DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<KuntoLps2DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
