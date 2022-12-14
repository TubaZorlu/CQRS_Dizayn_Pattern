using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpSchool_CQRS_Projects.CQRS.Queries.ProductQueries
{
    public class GetProductHumanResourceByIdQuery
    {
        public GetProductHumanResourceByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }


    }
}
