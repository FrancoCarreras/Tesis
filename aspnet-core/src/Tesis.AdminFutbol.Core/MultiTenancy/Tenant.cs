using Abp.MultiTenancy;
using Tesis.AdminFutbol.Authorization.Users;

namespace Tesis.AdminFutbol.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
