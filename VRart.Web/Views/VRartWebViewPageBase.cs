using Abp.Web.Mvc.Views;

namespace VRart.Web.Views
{
    public abstract class VRartWebViewPageBase : VRartWebViewPageBase<dynamic>
    {

    }

    public abstract class VRartWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected VRartWebViewPageBase()
        {
            LocalizationSourceName = VRartConsts.LocalizationSourceName;
        }
    }
}