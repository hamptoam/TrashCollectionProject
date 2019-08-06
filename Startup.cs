using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrashCollection.Startup))]
namespace TrashCollection
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
