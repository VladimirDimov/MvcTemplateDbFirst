using Microsoft.Owin;

using Owin;

[assembly: OwinStartupAttribute(typeof(TourPoc.Web.Startup))]

namespace TourPoc.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
