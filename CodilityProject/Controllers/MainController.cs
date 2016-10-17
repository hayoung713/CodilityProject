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


        [Route("Lesson1")]
        public ActionResult Lesson1()
        {
            return View();
        }
    }
}