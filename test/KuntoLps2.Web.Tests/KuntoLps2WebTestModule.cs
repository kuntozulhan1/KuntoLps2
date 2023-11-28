using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using KuntoLps2.EntityFrameworkCore;
using KuntoLps2.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace KuntoLps2.Web.Tests
{
    [DependsOn(
        typeof(KuntoLps2WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class KuntoLps2WebTestModule : AbpModule
    {
        public KuntoLps2WebTestModule(KuntoLps2EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(KuntoLps2WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(KuntoLps2WebMvcModule).Assembly);
        }
    }
}