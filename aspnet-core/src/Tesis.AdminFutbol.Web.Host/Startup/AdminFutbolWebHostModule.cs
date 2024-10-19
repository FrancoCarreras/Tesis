using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Tesis.AdminFutbol.Configuration;

namespace Tesis.AdminFutbol.Web.Host.Startup
{
    [DependsOn(
       typeof(AdminFutbolWebCoreModule))]
    public class AdminFutbolWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AdminFutbolWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AdminFutbolWebHostModule).GetAssembly());
        }
    }
}
