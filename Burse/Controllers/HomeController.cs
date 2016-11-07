using System.Web.Mvc;

namespace Burse.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var overview = new Models.BurseItemOverview {EventMessage = "Страница загружена"};
            var result = View(overview);
            return result;
        }
        public ActionResult AddBuyOrder()
        {
            var result = RedirectToAction("Index", "Home");
            return result;
        }
        public ActionResult AddSellOrder()
        {
            var result = RedirectToAction("Index", "Home");
            return result;
        }
    }
}