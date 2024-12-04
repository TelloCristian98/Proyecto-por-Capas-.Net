using System.Web.Http;
using Unity;
using Unity.Lifetime;
using Unity.WebApi;
using BLL;
using SLC;

namespace Service
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // Register all your components with the container here
            container.RegisterType<IProductService, ProductLogic>(new HierarchicalLifetimeManager());

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}
