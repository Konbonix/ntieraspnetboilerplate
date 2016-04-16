using Abp.Web.Mvc.Controllers;

namespace VRart.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class VRartControllerBase : AbpController
    {
        protected VRartControllerBase()
        {
            LocalizationSourceName = VRartConsts.LocalizationSourceName;
        }
    }
}