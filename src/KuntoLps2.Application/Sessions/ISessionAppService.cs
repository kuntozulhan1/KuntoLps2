using System.Threading.Tasks;
using Abp.Application.Services;
using KuntoLps2.Sessions.Dto;

namespace KuntoLps2.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
