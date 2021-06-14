using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TrialTemplate.EntityFrameworkCore
{
    public static class TrialTemplateDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TrialTemplateDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TrialTemplateDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
