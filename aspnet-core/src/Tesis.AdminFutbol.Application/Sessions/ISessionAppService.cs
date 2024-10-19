using System.Threading.Tasks;
using Abp.Application.Services;
using Tesis.AdminFutbol.Sessions.Dto;

namespace Tesis.AdminFutbol.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
