using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NorthwindTrader.MvcWebUI.Startup))]
namespace NorthwindTrader.MvcWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
