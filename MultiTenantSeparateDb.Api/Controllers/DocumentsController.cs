using Microsoft.AspNetCore.Mvc;
using MultiTenant.Core.Documents.Dto;
using MultiTenant.Core.Documents.Services;

namespace MultiTenantSeparateDb.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentsController : ControllerBase
    {
        private readonly IDocumentsService _documentsService;

        public DocumentsController(IDocumentsService documentsService)
        {
            _documentsService = documentsService;
        }

        [HttpGet("{documentId}", Name = "GetDocumentById")]
        public async Task<DocumentsDisplayModel> GetDocumentById(Guid documentId, CancellationToken cancellationToken = default)
        {
            return await _documentsService.GetById(documentId);
        }
    }
}
