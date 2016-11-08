using System.Web.Mvc;

namespace Burse.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var requestForm = Request?.Form;
            var overview = new Models.BurseItemOverview(requestForm) ;
            overview.Boot();

            var result = View(overview);
            return result;
        }
        public ActionResult AddBuyOrder()
        {
            var requestForm = Request?.Form;
            var overview = new Models.BurseItemOverview(requestForm);
            var result = RedirectToAction("Index", "Home");
            return result;
        }
        public ActionResult AddSellOrder()
        {
            var requestForm = Request?.Form;
            var overview = new Models.BurseItemOverview(requestForm);
            var result = RedirectToAction("Index", "Home");
            return result;
        }
    }
}