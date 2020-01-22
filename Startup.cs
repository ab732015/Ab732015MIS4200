using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ab732015MIS4200.Startup))]
namespace Ab732015MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
