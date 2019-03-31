using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //当提供了初始化数据时，使用该形式，以初始化数据库策略并填充一些数据（当某个Model改变了，就删除原来的数据库创建新的数据库）
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MovieDBContext, Migrations.Configuration>());
        }
    }
}