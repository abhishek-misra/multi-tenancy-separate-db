using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MultiTenant.Core.Tenants.Domain;

namespace MultiTenant.Core.Documents.Domain
{
    [Table("documents")]
    public class Document
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Guid TenantId { get; set; }

        [ForeignKey(nameof(TenantId))]
        public virtual Tenant Tenants { get; set; }
    }
}
