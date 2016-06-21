using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoursASP.MVC4.Startup))]
namespace CoursASP.MVC4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
