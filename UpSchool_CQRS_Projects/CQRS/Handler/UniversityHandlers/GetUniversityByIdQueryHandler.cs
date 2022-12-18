using MediatR;
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
    public class GetUniversityByIdQueryHandler : IRequestHandler<GetUniversityByIdQuery, GetUniversityByIdQueryResult>
    {
        private readonly ProductContext _context;


        public GetUniversityByIdQueryHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<GetUniversityByIdQueryResult> Handle(GetUniversityByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Universities.FindAsync(request.Id);
            return new GetUniversityByIdQueryResult
            {
                Id = values.Id,
                City = values.City,
                Name = values.Population,
                Population = values.Population,
            };
        }
    }
}
