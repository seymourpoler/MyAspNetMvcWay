using System;
using System.Collections.Generic;
using Domain.Modules.Products.Models;

namespace Domain.Modules.Products.Services
{
    public class ProductService
    {
        public IEnumerable<Product> All()
        {
            return new[]
                {
                    new Product(id: Guid.NewGuid(),
                        name: "productOne",
                        price: (decimal)123), 
                    new Product(id: Guid.NewGuid(),
                        name: "productTwo",
                        price: (decimal)124), 
                    new Product(id: Guid.NewGuid(),
                        name: "productThree",
                        price: (decimal)145), 
                };
        }
    }
}
