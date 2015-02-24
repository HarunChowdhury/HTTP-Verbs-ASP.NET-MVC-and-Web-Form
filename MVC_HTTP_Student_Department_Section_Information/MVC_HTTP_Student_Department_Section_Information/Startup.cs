using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_HTTP_Student_Department_Section_Information.Startup))]
namespace MVC_HTTP_Student_Department_Section_Information
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
