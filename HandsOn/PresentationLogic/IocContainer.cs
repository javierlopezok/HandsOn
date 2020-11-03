using Autofac;
using Autofac.Core.Lifetime;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Business_Logic;
using DataAccess;
using Owin;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;

namespace HandsOn.PresentationLogic
{

    public static class IocContainer
    {
 
        public static void Setup(IAppBuilder app)
        {

            var builder = new ContainerBuilder();
            var requestTag = MatchingScopeLifetimeTags.RequestLifetimeScopeTag;

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<EmployeeService>().As<IEmployeeService>();
            builder.RegisterType<ExternalApi>().As<IExternalApi>().InstancePerMatchingLifetimeScope(requestTag);       

            IContainer container = AutofacConfig(app, builder);

            var webApiResolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = webApiResolver;

            var mvcResolver = new AutofacDependencyResolver(container);
            DependencyResolver.SetResolver(mvcResolver);

        }

        private static IContainer AutofacConfig(IAppBuilder app, ContainerBuilder builder)
        {
            return builder.Build();
        }
      
    }
}