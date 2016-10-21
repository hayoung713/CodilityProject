using System.Web.Mvc;

namespace CodilityProject.Controllers
{
    [RoutePrefix("")]
    public class MainController : CommonController
    {
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("Lessons1")]
        public ActionResult Lessons1()
        {
            return View();
        }

        [Route("Lessons2")]
        public ActionResult Lessons2()
        {
            return View();
        }
    }
}