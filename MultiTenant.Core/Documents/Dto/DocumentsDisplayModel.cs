namespace MultiTenant.Core.Documents.Dto;

public class DocumentsDisplayModel
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }
        
    /// <summary>
    /// Init Object
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="description"></param>
    public DocumentsDisplayModel(Guid id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }
        
    /// <summary>
    /// Init Object
    /// </summary>
    /// <param name="id"></param>
    public DocumentsDisplayModel(Guid id)
    {
        Id = id;
    }
}