using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using KuntoLps2.Configuration;

namespace KuntoLps2.Web.Host.Startup
{
    [DependsOn(
       typeof(KuntoLps2WebCoreModule))]
    public class KuntoLps2WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public KuntoLps2WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(KuntoLps2WebHostModule).GetAssembly());
        }
    }
}
