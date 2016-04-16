using System.Reflection;
using Abp.Modules;

namespace VRart
{
    [DependsOn(typeof(VRartCoreModule))]
    public class VRartApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
