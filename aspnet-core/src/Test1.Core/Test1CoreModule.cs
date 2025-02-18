﻿using Abp.Localization;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Runtime.Security;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using Test1.Authorization.Roles;
using Test1.Authorization.Users;
using Test1.Configuration;
using Test1.Localization;
using Test1.MultiTenancy;
using Test1.Timing;

namespace Test1
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class Test1CoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            Test1LocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = Test1Consts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
            
            Configuration.Localization.Languages.Add(new LanguageInfo("fa", "فارسی", "famfamfam-flags ir"));
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = Test1Consts.DefaultPassPhrase;
            SimpleStringCipher.DefaultPassPhrase = Test1Consts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Test1CoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
