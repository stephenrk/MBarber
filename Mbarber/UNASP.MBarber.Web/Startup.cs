using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UNASP.MBarber.Web.Startup))]
namespace UNASP.MBarber.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
