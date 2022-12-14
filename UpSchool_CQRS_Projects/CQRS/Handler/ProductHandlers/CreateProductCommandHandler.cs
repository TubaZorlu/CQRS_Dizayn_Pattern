using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.CQRS.Commands.ProductCommands;
using UpSchool_CQRS_Projects.DAL.Context;
using UpSchool_CQRS_Projects.DAL.Entities;

namespace UpSchool_CQRS_Projects.CQRS.Handler.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly ProductContext _productContext;

        public CreateProductCommandHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public void Handle(CreateProductCommand command) 
        {
            _productContext.Products.Add(new Product
            {
                Brand = command.Brand,
                Name = command.Name,
                Cost = command.Cost,
                Stock = command.Stock,
                Tax = command.Tax,
                PurchasePrice = command.PurchasePrice,
                SalePrice = command.SalePrice,
                Size = command.Size,
                ProduceOfDate = command.ProduceOfDate,
                EndOfDate = command.EndOfDate,
                Status = true


            }) ;
            _productContext.SaveChanges();
        }

    }
}
