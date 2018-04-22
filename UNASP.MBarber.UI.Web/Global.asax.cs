using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace UNASP.MBarber.UI.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Inicialiar AutoMapper
            App_Start.AutoMapperConfig.Initialize();
        }
    }
}
