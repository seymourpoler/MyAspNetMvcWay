using System;
using System.Web.Mvc;

namespace MyAspNetMvcWay
{
	public class CustomViewEngine : RazorViewEngine
	{
		public CustomViewEngine ()
		{
			ViewLocationFormats = new[] 
			{
				"{1}/Views/{0}",
				"~/{1}/Views/{0}",
				"/{1}/Views/{0}",
				"{1}/Views/{0}"
			};
		}
	}
}

