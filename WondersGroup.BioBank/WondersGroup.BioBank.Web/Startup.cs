using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WondersGroup.BioBank.Web.Startup))]
namespace WondersGroup.BioBank.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
