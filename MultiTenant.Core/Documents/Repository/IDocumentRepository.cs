using MultiTenant.Core.Documents.Domain;

namespace MultiTenant.Core.Documents.Repository
{
    public interface IDocumentRepository
    {
        Task<Document?> GetById(Guid id, CancellationToken cancellationToken = default);
    }
}
