using Microsoft.EntityFrameworkCore;
using TenantServices.Core.Tenants.Domain;

namespace TenantServices.Core.Tenants.Repository
{
    public class TenantPodRepository : ITenantPodRepository
    {
        private readonly TenantDbContext _context;

        public TenantPodRepository(TenantDbContext context)
        {
            _context = context;
        }

        public async Task<TenantPod?> GetByTenantId(Guid tenantId, CancellationToken cancellationToken = default)
        {
            return await _context.TenantPods.FirstOrDefaultAsync(x => x.TenantId == tenantId, cancellationToken);
        }
    }
}
