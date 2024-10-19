using System.Threading.Tasks;
using Abp.Application.Services;
using Tesis.AdminFutbol.Authorization.Accounts.Dto;

namespace Tesis.AdminFutbol.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
