using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Tesis.AdminFutbol.EntityFrameworkCore;
using Tesis.AdminFutbol.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Tesis.AdminFutbol.Web.Tests
{
    [DependsOn(
        typeof(AdminFutbolWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class AdminFutbolWebTestModule : AbpModule
    {
        public AdminFutbolWebTestModule(AdminFutbolEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AdminFutbolWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(AdminFutbolWebMvcModule).Assembly);
        }
    }
}