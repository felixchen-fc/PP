using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PP.Startup))]
namespace PP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
