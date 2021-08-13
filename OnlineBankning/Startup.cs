using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineBankning.Startup))]
namespace OnlineBankning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
