using Microsoft.EntityFrameworkCore;
using MultiTenant.Core;
using TenantServices.Core;

namespace MultiTenantSeparateDb.Api.Configurations
{
    public static class PgSqlConfiguration
    {
        public static void ConfigurePgSqlDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var section = configuration.GetSection("ConnectionStrings");
            var tenantConnectionString = section["TenantDbConnection"];


            services.AddDbContext<TenantDbContext>(options =>
            {
                options.EnableSensitiveDataLogging();

                options.UseNpgsql(tenantConnectionString, b =>
                {
                    b.SetPostgresVersion(new Version(9, 6));
                    b.EnableRetryOnFailure(10, TimeSpan.FromSeconds(30), null);
                    b.CommandTimeout(300);
                });

                options.UseNpgsql(tenantConnectionString).UseSnakeCaseNamingConvention();
            });

            services.AddDbContext<MultiTenantDbContext>();
        }
    }
}
