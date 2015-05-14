using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyAspNetMvcWay
{
	public class MvcApplication : System.Web.HttpApplication
	{
		public static void RegisterRoutes (RouteCollection routes)
		{
			routes.IgnoreRoute ("{resource}.axd/{*pathInfo}");

			routes.MapRoute (
				"ProductsIndex",
				"Products/Index",
				new { controller = "Products", action = "Index" }
			);

			routes.MapRoute (
				"ProductsAll",
				"Products/All",
				new { controller = "Products", action = "All" }
			);

			routes.MapRoute (
				"Default",
				"{controller}/{action}/{id}",
				new { controller = "Home", action = "Index", id = "" }
			);

		}

		public static void RegisterGlobalFilters (GlobalFilterCollection filters)
		{
			filters.Add (new HandleErrorAttribute ());
		}

		protected void Application_Start ()
		{
			AreaRegistration.RegisterAllAreas ();
			RegisterGlobalFilters (GlobalFilters.Filters);
			RegisterRoutes (RouteTable.Routes);

			ViewEngines.Engines.Clear();
			ViewEngines.Engines.Add(new CustomViewEngine());
		}
	}
}
