using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Transient.Startup))]
namespace Transient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
