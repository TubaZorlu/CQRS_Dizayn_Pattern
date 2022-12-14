using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.CQRS.Queries.StudentQueries;
using UpSchool_CQRS_Projects.CQRS.Result.StudentResult;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handler.StudentHandlers
{
    public class GetStudentByIdQueryHandler
    {
        private readonly ProductContext _context;

        public GetStudentByIdQueryHandler(ProductContext context)
        {
            _context = context;
        }
        public GetStudentByIdQueryResult Handle(GetStudentByIdQuery query) 
        {
            var values = _context.Students.Find(query.id);

            return new GetStudentByIdQueryResult
            {
                Age = values.Age,
                City = values.City,
                Name = values.Name,
                Surname = values.Surname,
                StudentID = values.StudentID
            };
        }
    }
}
