using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using MyAspNetWay.Products.Controllers.Api;

namespace MyAspNetWay
{
    public class CustomHttpControllerSelector : DefaultHttpControllerSelector
    {
        private readonly HttpConfiguration _configuration;

        public CustomHttpControllerSelector(HttpConfiguration configuration)
        : base(configuration)
        {
            _configuration = configuration;
        }

        public override HttpControllerDescriptor SelectController(HttpRequestMessage request)
        {
            return new HttpControllerDescriptor(_configuration, "ProductsApiController", typeof(ProductsApiController));
        }
    }
}