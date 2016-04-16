using Abp.Application.Services;

namespace VRart
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class VRartAppServiceBase : ApplicationService
    {
        protected VRartAppServiceBase()
        {
            LocalizationSourceName = VRartConsts.LocalizationSourceName;
        }
    }
}