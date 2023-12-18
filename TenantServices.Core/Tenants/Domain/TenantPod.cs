using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TenantServices.Core.Tenants.Domain
{
    [Table("tenant_pods")]
    public class TenantPod
    {
        [Key]
        public Guid Id { get; protected set; }

        public Guid TenantId { get; protected set; }

        public string ConnectionString { get; protected set; }

        [ForeignKey(nameof(TenantId))]
        public virtual Tenant Tenant { get; protected set; }

        /// <summary>
        /// Constructor
        /// </summary>
        protected TenantPod()
        {
            
        }

        /// <summary>
        /// Initializes the object
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tenantId"></param>
        /// <param name="connectionString"></param>
        public TenantPod(Guid id, Guid tenantId, string connectionString)
        {
            Id = id;
            TenantId = tenantId;
            ConnectionString = connectionString;
        }
    }
}
