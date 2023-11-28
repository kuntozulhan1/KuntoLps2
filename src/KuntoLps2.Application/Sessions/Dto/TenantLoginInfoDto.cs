using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using KuntoLps2.MultiTenancy;

namespace KuntoLps2.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
