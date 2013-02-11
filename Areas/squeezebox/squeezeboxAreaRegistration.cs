using System.Web.Mvc;

namespace hydra.Areas.squeezebox
{
    public class squeezeboxAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "squeezebox";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "squeezebox_default",
                "squeezebox/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
