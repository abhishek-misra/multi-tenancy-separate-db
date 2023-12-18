using Microsoft.EntityFrameworkCore;
using MultiTenant.Core.Documents.Domain;

namespace MultiTenant.Core.Documents.Repository
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly MultiTenantDbContext _context;

        public DocumentRepository(MultiTenantDbContext context)
        {
            _context = context;
        }

        public async Task<Document?> GetById(Guid id, CancellationToken cancellationToken = default)
        {
            return await _context.Documents.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }
    }
}
