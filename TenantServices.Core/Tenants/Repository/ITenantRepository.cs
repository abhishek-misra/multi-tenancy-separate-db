using TenantServices.Core.Tenants.Domain;

namespace TenantServices.Core.Tenants.Repository
{
    public interface ITenantRepository
    {
        Task<Tenant?> GetById(Guid tenantId, CancellationToken cancellationToken = default);
    }
}
