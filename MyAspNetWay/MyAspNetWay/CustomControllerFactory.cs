﻿using MyAspNetWay.Products.Controllers;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyAspNetWay
{
    public class CustomControllerFactory : DefaultControllerFactory
    {
        public virtual IController CreateController(RequestContext requestContext, string controllerName)
        {
            return new ProductsController();
        }

        public override void ReleaseController(IController controller)
        {
            IDisposable dispose = controller as IDisposable;
            if (dispose != null)
            {
                dispose.Dispose();
            }
        }
    }
}