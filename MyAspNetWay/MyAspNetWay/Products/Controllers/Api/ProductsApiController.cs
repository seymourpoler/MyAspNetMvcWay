using System;
using System.Net.Http;
using System.Web.Http;
using MyAspNetWay.Products.Models;

namespace MyAspNetWay.Products.Controllers.Api
{
    public class ProductsApiController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Upate(Product product)
        {
            throw new NotImplementedException();
        }
    }
}