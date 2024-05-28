using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Test1.EntityFrameworkCore;
using Test1.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Test1.Web.Tests
{
    [DependsOn(
        typeof(Test1WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class Test1WebTestModule : AbpModule
    {
        public Test1WebTestModule(Test1EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Test1WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(Test1WebMvcModule).Assembly);
        }
    }
}