using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HW4_MultiLayerDatabaseData.Startup))]
namespace HW4_MultiLayerDatabaseData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
