using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Domain.Modules.Products.Services;
using MyAspNetWay.Products.Models;

namespace MyAspNetWay.Products.Controllers.Api
{
    public class ProductsApiController : ApiController
    {
        private ProductService productService;

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
    }
}