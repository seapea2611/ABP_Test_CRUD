using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Test1.Authorization;

namespace Test1
{
    [DependsOn(
        typeof(Test1CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Test1ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<Test1AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(Test1ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
