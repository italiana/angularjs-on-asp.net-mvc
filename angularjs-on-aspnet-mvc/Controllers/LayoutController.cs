using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace angularjs_on_aspnet_mvc.Controllers
{
    public class LayoutController : Controller
    {
        // GET: Layout
        public ActionResult Shell()
        {
            return PartialView();
        }

        public ActionResult SideBar()
        {
            return PartialView();
        }

        public ActionResult TopNav()
        {
            return PartialView();
        }
    }
}