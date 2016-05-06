using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrucibleReview.Startup))]
namespace CrucibleReview
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
