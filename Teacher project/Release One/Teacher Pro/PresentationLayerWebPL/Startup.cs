using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PresentationLayerWebPL.Startup))]
namespace PresentationLayerWebPL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
