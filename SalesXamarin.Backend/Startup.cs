using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesXamarin.Backend.Startup))]
namespace SalesXamarin.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
