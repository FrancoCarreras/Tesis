using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Tesis.AdminFutbol.Authorization;

namespace Tesis.AdminFutbol
{
    [DependsOn(
        typeof(AdminFutbolCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AdminFutbolApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AdminFutbolAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AdminFutbolApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
