using Abp.Application.Services;
using Tesis.AdminFutbol.MultiTenancy.Dto;

namespace Tesis.AdminFutbol.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

