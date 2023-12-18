using Microsoft.EntityFrameworkCore;
using MultiTenant.Core.Documents.Domain;
using MultiTenant.Core.Tenants.Domain;
using TenantServices.Core.Tenants.Services;

namespace MultiTenant.Core
{
    public class MultiTenantDbContext : DbContext
    {
        private readonly ITenantsService _tenantsService;


        public MultiTenantDbContext(DbContextOptions<MultiTenantDbContext> options, ITenantsService tenantsService) :
            base(options)
        {
            _tenantsService = tenantsService;
        }

        public DbSet<Tenant> Tenants { get; set; }

        public DbSet<Document> Documents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _tenantsService.GetConnectionByTenant();

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("Tenant Connection Not found");
            }

            optionsBuilder.EnableSensitiveDataLogging();

            optionsBuilder.UseNpgsql(connectionString, b =>
            {
                b.SetPostgresVersion(new Version(9, 6));
                b.EnableRetryOnFailure(10, TimeSpan.FromSeconds(30), null);
                b.CommandTimeout(300);
            });

            optionsBuilder.UseNpgsql(connectionString).UseSnakeCaseNamingConvention();
        }
    }
}
