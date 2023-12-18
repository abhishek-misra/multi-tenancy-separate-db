using TenantServices.Core.Tenants.Domain;

namespace TenantServices.Core.Tenants.Repository
{
    public interface ITenantPodRepository
    {
        Task<TenantPod?> GetByTenantId(Guid tenantId, CancellationToken cancellationToken = default);
    }
}
