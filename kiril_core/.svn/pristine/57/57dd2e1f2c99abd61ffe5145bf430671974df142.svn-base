using Markum.Cloud.Services.Interfaces;
using Markum.Cloud.Services.Services;
using Microsoft.Practices.Unity;

namespace Markum.Cloud.IOC
{
    public class UnityConfig
    {
        static UnityContainer container = new UnityContainer();
        public static IUnityContainer RegisterComponents()
        {
            //var container = new UnityContainer();
            return RegisterTypes();
        }
        public static object GetRegisterType<T>()
        {
            return (T)container.Resolve<T>();
        }

        private static IUnityContainer RegisterTypes()
        {
            //container.RegisterType<IUnitOfWork, EfMarkumUnitOfWork>(new HierarchicalLifetimeManager());
            //container.RegisterType<ICustomerAccountService, CustomerAccountService>(new HierarchicalLifetimeManager());
            container.RegisterType<IHostingServiceWindowsPanel, HostingServiceWindowsPanel>(new HierarchicalLifetimeManager());
            container.RegisterType<IServerService, SolusVmService>(new HierarchicalLifetimeManager());
            return container;
        }
    }
}
