using System.Reflection;
using Abp.Modules;

namespace VRart
{
    public class VRartCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
