using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.CQRS.Result.ProductResult;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handler.ProductHandlers
{
    public class GetProductAccounterQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductAccounterQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public List<GetProductAccounterQueryResult> Handle()
        {
            var values = _productContext.Products.Select(x => new GetProductAccounterQueryResult
            {

                ProductID = x.ProductID,
                Brand = x.Brand,
                Name = x.Name,
                PurchasePrice = x.PurchasePrice,
                SalePrice = x.SalePrice,
                Stock = x.Stock,
                Tax = x.Tax
            }).AsNoTracking().ToList();

            return values;
        }
    }
}
