using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AGP2Application
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // Il faut lancer une première fois avec la ligne du dessous pour créer la DB puis utiliser l'autre
            //Database.SetInitializer(new DropCreateDatabaseAlways<AGP2Application.AGPModel>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AGP2Application.AGPModel>());
        }
    }
}
