using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Tesis.AdminFutbol.EntityFrameworkCore
{
    public static class AdminFutbolDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AdminFutbolDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public static void Configure(DbContextOptionsBuilder<AdminFutbolDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection, ServerVersion.AutoDetect(connection.ConnectionString));
        }
    }
}
