using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vividly_app.Startup))]
namespace vividly_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}