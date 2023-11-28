using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using KuntoLps2.Authorization;

namespace KuntoLps2
{
    [DependsOn(
        typeof(KuntoLps2CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class KuntoLps2ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<KuntoLps2AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(KuntoLps2ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
