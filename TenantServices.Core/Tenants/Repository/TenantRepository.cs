using Microsoft.EntityFrameworkCore;
using TenantServices.Core.Tenants.Domain;

namespace TenantServices.Core.Tenants.Repository
{
    public class TenantRepository : ITenantRepository
    {
        private readonly TenantDbContext _context;

        public TenantRepository(TenantDbContext context)
        {
            _context = context;
        }

        public async Task<Tenant?> GetById(Guid tenantId, CancellationToken cancellationToken = default)
        {
            return await _context.Tenants.FirstOrDefaultAsync(x => x.Id == tenantId, cancellationToken);
        }
    }
}
