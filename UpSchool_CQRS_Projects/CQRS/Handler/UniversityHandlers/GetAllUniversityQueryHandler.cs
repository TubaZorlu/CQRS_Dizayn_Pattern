using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.CQRS.Queries.UniversityQueries;
using UpSchool_CQRS_Projects.CQRS.Result.UniversityResult;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handler.UniversityHandlers
{
    public class GetAllUniversityQueryHandler:IRequestHandler<GetAllUniversityQuery,List<GetAlluniversityQueryResult>>
    {
        private readonly ProductContext _context;

        public GetAllUniversityQueryHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<List<GetAlluniversityQueryResult>> Handle(GetAllUniversityQuery request, CancellationToken cancellationToken)
        {
            return await _context.Universities.Select(x => new GetAlluniversityQueryResult
            {
                Id = x.Id,
                City = x.City,
                Name = x.Name

            }).AsNoTracking().ToListAsync();
        }
    }
}
