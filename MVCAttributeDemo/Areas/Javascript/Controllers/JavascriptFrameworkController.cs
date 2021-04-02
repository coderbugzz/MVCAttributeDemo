using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAttributeDemo.Areas.Javascript.Controllers
{
    [RouteArea("Javascript")] 
    [RoutePrefix("JavascriptFramework")]
    public class JavascriptFrameworkController : Controller
    {
        // GET: Javascript/JavascriptFramework
        public ActionResult Vue()
        {
            return View();
        }
        public ActionResult AngularJS()
        {
            return View();
        }
    }
}