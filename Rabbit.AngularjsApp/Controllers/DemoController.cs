using System.Web.Mvc;

namespace AngularjsApp.MvcClient.Controllers
{
    public class DemoController : Controller
    {
        public ActionResult Welcome()
        {
            return PartialView();
        }

        public ActionResult Test()
        {
            return PartialView();
        }
    }
}