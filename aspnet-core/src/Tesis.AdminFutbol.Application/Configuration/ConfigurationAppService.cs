using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Tesis.AdminFutbol.Configuration.Dto;

namespace Tesis.AdminFutbol.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AdminFutbolAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
