using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.CQRS.Result.UniversityResult;

namespace UpSchool_CQRS_Projects.CQRS.Queries.UniversityQueries
{
    public class GetUniversityByIdQuery:IRequest<GetUniversityByIdQueryResult>
    {
        public int Id { get; set; }

        public GetUniversityByIdQuery(int id)
        {
            this.Id = id;
        }
    }
}
