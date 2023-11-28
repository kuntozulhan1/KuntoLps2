using Abp.Application.Services;
using KuntoLps2.MultiTenancy.Dto;

namespace KuntoLps2.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

