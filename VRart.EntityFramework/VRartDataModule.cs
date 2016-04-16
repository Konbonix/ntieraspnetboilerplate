using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using VRart.EntityFramework;

namespace VRart
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(VRartCoreModule))]
    public class VRartDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<VRartDbContext>(null);
        }
    }
}
