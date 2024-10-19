using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Tesis.AdminFutbol.Configuration;
using Tesis.AdminFutbol.EntityFrameworkCore;
using Tesis.AdminFutbol.Migrator.DependencyInjection;

namespace Tesis.AdminFutbol.Migrator
{
    [DependsOn(typeof(AdminFutbolEntityFrameworkModule))]
    public class AdminFutbolMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AdminFutbolMigratorModule(AdminFutbolEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(AdminFutbolMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                AdminFutbolConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AdminFutbolMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
