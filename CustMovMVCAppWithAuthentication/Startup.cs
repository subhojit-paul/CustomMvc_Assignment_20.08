using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustMovMVCAppWithAuthentication.Startup))]
namespace CustMovMVCAppWithAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
