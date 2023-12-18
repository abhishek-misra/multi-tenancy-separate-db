using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TenantServices.Core.Tenants.Domain
{
    [Table("tenants")]
    public class Tenant
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; protected set; }

        protected Tenant()
        {
            
        }

        public Tenant(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
