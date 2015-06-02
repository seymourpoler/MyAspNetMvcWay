using Domain.Modules.Products.Services;
using MyAspNetWay.Products.Models;
using System;
using System.Linq;
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
            var productsFound = productService
                                        .All()
                                        .Select(Map);
            return  HttpResponseMessageBuilder.Build(productsFound);
        }

        [HttpPost]
        public HttpResponseMessage Upate(ProductResponse productResponse)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public HttpResponseMessage Delete(Guid productId)
        {
            productService.Remove(productId);
            return HttpResponseMessageBuilder.Build();
        }

        private ProductResponse Map(Domain.Modules.Products.Models.Product product)
        {
            return  new ProductResponse
            {
                id = product.Id,
                name = product.Name
            };
        }
    }
}