using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.CQRS.Queries.ProductQueries;
using UpSchool_CQRS_Projects.CQRS.Result.ProductResult;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handler.ProductHandlers
{
    public class GetProductAccounterByIdQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductAccounterByIdQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public GetProductAccounterByIdQueryResult Handle(GetProductAcounterByIdQuery query) 
        {
            var values = _productContext.Products.Find(query.id);

            return new GetProductAccounterByIdQueryResult
            {
                ProductID=values.ProductID,
                Brand=values.Brand,
                Description=values.Description,
                Name=values.Name,
                PurchasePrice=values.PurchasePrice,
                SalePrice=values.SalePrice,
                Stock=values.Stock,
                Tax=values.Tax
                
            };
        }
    }
}
