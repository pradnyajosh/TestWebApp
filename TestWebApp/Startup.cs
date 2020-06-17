using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestWebApp.Startup))]
namespace TestWebApp
{//commented for testing
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
