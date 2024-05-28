using System.Threading.Tasks;
using Abp.Application.Services;
using Test1.Sessions.Dto;

namespace Test1.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
