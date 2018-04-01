using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UNASP.ProjetoCRUD.Web.Startup))]
namespace UNASP.ProjetoCRUD.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
