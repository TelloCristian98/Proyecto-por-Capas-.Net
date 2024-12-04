using System.Web.Http;
using Owin;
using Microsoft.Owin.Cors;
using Service;

namespace Test
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            UnityConfig.RegisterComponents();
            appBuilder.UseCors(CorsOptions.AllowAll); // Enable CORS
            appBuilder.UseWebApi(config); // Use Web API
        }
    }
}
