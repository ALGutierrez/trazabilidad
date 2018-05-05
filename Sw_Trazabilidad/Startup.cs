using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sw_Trazabilidad.Startup))]
namespace Sw_Trazabilidad
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
