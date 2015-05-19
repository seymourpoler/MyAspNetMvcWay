using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace MyAspNetWay
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "GetProducts",
                routeTemplate: "api/Products/Get",
                defaults: new { controller = "Products", action = "Get" },
                constraints: new { httpMethod = new System.Web.Http.Routing.HttpMethodConstraint(new HttpMethod("GET")) });

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });

            config.Formatters.JsonFormatter.MediaTypeMappings.Add(new QueryStringMapping("json", "true", "application/json"));
            //config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        }
    }
}
