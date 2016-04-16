using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace VRart
{
    [DependsOn(typeof(AbpWebApiModule), typeof(VRartApplicationModule))]
    public class VRartWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(VRartApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
