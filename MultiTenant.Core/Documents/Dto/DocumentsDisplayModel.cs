namespace MultiTenant.Core.Documents.Dto
{
    public class DocumentsDisplayModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DocumentsDisplayModel(Guid id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public DocumentsDisplayModel(Guid id)
        {
            Id = id;
        }
    }
}
