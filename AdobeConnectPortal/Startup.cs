using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdobeConnectPortal.Startup))]
namespace AdobeConnectPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
