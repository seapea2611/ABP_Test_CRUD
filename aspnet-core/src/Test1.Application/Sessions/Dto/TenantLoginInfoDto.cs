using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Test1.MultiTenancy;

namespace Test1.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
