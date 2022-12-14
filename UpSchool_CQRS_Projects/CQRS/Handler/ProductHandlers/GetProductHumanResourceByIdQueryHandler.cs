using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.CQRS.Queries.ProductQueries;
using UpSchool_CQRS_Projects.CQRS.Result.ProductResult;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handler.ProductHandlers
{
    public class GetProductHumanResourceByIdQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductHumanResourceByIdQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public GetProductHumanResourceByIdQueryResult Handle(GetProductHumanResourceByIdQuery query)
        {
            var values = _productContext.Products.Find(query.Id);

            return new GetProductHumanResourceByIdQueryResult
            {
                ProductID = values.ProductID,
                Brand = values.Brand,
                Name = values.Name,
                SalePrice = values.SalePrice,
            };

        }

    }
}
