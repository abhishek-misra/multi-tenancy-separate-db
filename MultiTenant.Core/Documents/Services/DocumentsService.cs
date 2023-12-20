using MultiTenant.Core.Documents.Dto;
using MultiTenant.Core.Documents.Repository;

namespace MultiTenant.Core.Documents.Services;

public class DocumentsService: IDocumentsService
{
    private readonly IDocumentRepository _documentRepository;

    public DocumentsService(IDocumentRepository documentRepository) => _documentRepository = documentRepository;

    public async Task<DocumentsDisplayModel> GetById(Guid id)
    {
        try
        {
            var objDocument = await _documentRepository.GetById(id);
            if (objDocument == null) return new DocumentsDisplayModel(Guid.Empty);

            return new DocumentsDisplayModel(objDocument.Id, objDocument.Name, objDocument.Description);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}