using System.Web.Mvc;

namespace AzureTests.Api.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("/swagger/ui/index");
        }
    }
}
