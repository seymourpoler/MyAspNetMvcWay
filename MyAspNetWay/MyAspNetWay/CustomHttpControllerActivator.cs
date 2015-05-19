using System;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using MyAspNetWay.Products.Controllers.Api;

namespace MyAspNetWay
{
    public class CustomHttpControllerActivator : IHttpControllerActivator 
    {
        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            return new ProductsApiController();
        }
    }
}