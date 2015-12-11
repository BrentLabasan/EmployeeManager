using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(employeeManager.Web.Startup))]
namespace employeeManager.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
