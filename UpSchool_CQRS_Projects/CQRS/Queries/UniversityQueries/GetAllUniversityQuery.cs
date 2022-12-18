using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.CQRS.Result.UniversityResult;

namespace UpSchool_CQRS_Projects.CQRS.Queries.UniversityQueries
{
    public class GetAllUniversityQuery:IRequest<List<GetAlluniversityQueryResult>>
    {

    }
}
