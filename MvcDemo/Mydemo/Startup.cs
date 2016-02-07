using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mydemo.Startup))]
namespace Mydemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
