using System.Threading.Tasks;
using KuntoLps2.Configuration.Dto;

namespace KuntoLps2.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
