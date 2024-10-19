using System.Threading.Tasks;
using Tesis.AdminFutbol.Configuration.Dto;

namespace Tesis.AdminFutbol.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
