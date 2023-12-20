using MultiTenant.Core.Documents.Dto;

namespace MultiTenant.Core.Documents.Services;

public interface IDocumentsService
{
    Task<DocumentsDisplayModel> GetById(Guid  id);
}