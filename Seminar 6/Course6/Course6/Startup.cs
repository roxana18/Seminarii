using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Course6.Startup))]
namespace Course6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
