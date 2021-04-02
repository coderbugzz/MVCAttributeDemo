using System.Web.Mvc;

namespace MVCAttributeDemo.Areas.Javascript
{
    public class JavascriptAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Javascript";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Javascript_default",
                "Javascript/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}