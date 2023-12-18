using Microsoft.EntityFrameworkCore;
using TenantServices.Core.Tenants.Domain;

namespace TenantServices.Core
{
    public class TenantDbContext : DbContext
    {
        public TenantDbContext(DbContextOptions<TenantDbContext> options) : base(options) { }
        
        public DbSet<Tenant> Tenants { get; set; }

        public DbSet<TenantPod> TenantPods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
