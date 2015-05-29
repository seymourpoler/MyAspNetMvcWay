using Domain.Modules.Products.Services;
using MyAspNetWay.Products.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyAspNetWay.Products.Controllers.Api
{
    public class ProductsApiController : ApiController
    {
        private readonly ProductService productService;

        public ProductsApiController()
        {
            productService = new ProductService();
        }

        [HttpGet]
        public HttpResponseMessage Get()
        {
            var products = productService.All();
            return Request.CreateResponse(HttpStatusCode.OK, products);
        }

        [HttpPost]
        public HttpResponseMessage Upate(Product product)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public HttpResponseMessage Delete(Guid productId)
        {
            productService.Remove(productId);
        }
    }
}