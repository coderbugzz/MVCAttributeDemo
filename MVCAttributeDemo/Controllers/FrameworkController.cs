using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAttributeDemo.Controllers
{
    [RoutePrefix("Framework")]
    public class FrameworkController : Controller
    {
        // GET: Framework
        [Route("AngularFramework/{id:int}")]
        public ActionResult Angular(int id)
        {
            return View();
        }
        [Route("ReactFramework/{type:regex(^[a-zA-Z]*$)}")]
        public ActionResult React(string type)
        {
            return View();
        }
        [Route("BlazorFramework")]
        public ActionResult Blazor()
        {
            return View();
        }
    }
}