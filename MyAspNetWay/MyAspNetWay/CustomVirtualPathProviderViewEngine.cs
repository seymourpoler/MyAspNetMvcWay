using System.Web.Mvc;

namespace MyAspNetWay
{
    public class CustomVirtualPathProviderViewEngine : VirtualPathProviderViewEngine
    {
        public CustomVirtualPathProviderViewEngine()
        {
            ViewLocationFormats = new[]
                {
                    "~/{1}/Views/{0}",
                    "~{1}/Views/{0}",
                    "{1}/Views/{0}"
                };

        }

        protected override IView CreatePartialView (ControllerContext controllerContext, string partialPath)
        {
            var physicalpath = controllerContext.HttpContext.Server.MapPath(partialPath);
            return new CustomView(physicalpath);
        }

        protected override IView CreateView(ControllerContext controllerContext, string viewPath, string masterPath)
        {
            var physicalpath = controllerContext.HttpContext.Server.MapPath(viewPath);
            return new CustomView(physicalpath);
        }

    }
}