using System.Threading.Tasks;
using Test1.Configuration.Dto;

namespace Test1.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
