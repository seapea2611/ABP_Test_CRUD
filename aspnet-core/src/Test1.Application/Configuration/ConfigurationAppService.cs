using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Test1.Configuration.Dto;

namespace Test1.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Test1AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }                       
    }

}
