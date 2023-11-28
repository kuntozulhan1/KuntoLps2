using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using KuntoLps2.Configuration.Dto;

namespace KuntoLps2.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : KuntoLps2AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
