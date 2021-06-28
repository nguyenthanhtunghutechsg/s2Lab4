using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(s2Lab4.Startup))]
namespace s2Lab4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
