using System.Web.Mvc;

namespace VRart.Web.Controllers
{
    public class HomeController : VRartControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}