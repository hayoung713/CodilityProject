using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
    }
}