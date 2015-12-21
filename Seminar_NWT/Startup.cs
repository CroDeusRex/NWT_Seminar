using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Seminar_NWT.Startup))]
namespace Seminar_NWT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
