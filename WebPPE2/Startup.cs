using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebPPE2.Startup))]
namespace WebPPE2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
