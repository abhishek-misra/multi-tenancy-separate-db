using Microsoft.AspNetCore.Http;

namespace TenantServices.Core.Tenants.Services
{
    public interface ITenantsService
    {
        string GetConnectionByTenant();
    }

    public class TenantsService: ITenantsService
    {
        private readonly HttpContext? _httpContext;

        public TenantsService(IHttpContextAccessor httpContextAccessor
           )
        {
            _httpContext = httpContextAccessor.HttpContext;
        }

        public string GetConnectionByTenant()
        {
            var tenantId = Guid.Empty;
            try
            {
                if (_httpContext == null)
                    throw new Exception("Tenant Not Found");

                var clientId = _httpContext.Request.Headers["x-tenant_id"];

                if (string.IsNullOrEmpty(clientId))
                {
                    throw new Exception("Tenant Request Header is missing.");
                }

                Guid.TryParse(clientId.ToString(), out tenantId);

                // Logic to get DB connection based on tenant

                // Dummy Connection string Her you should have your logic to get connection string and return it
                return "Server=127.0.0.1;Database=multiDemoMain;Port=5432;User Id=postgres;Password=qwe321Q!";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
