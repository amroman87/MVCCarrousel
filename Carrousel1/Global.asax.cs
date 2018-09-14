using Autofac;
using Carrousel1.Repository;
using Carrousel1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac.Builder;
using Autofac.Integration.Mvc;

namespace Carrousel1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private IContainer container;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);


            var builder = new ContainerBuilder(); 
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterInstance(new ImageFromXMLRepository()).As<IGetImagesRepository>();//ImageFromXMLRepository : IGetImagesRepository

            //GetImageService: IGetImagesService
            builder.RegisterInstance(new GetImageService(new ImageFromXMLRepository())).As<IGetImagesService>();

            container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}
