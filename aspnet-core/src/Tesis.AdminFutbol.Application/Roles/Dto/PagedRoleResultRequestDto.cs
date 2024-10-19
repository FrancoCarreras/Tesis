using Abp.Application.Services.Dto;

namespace Tesis.AdminFutbol.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

