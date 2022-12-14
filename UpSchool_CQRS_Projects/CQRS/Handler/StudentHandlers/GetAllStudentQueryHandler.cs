using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.CQRS.Result.StudentResult;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handler.StudentHandlers
{
    public class GetAllStudentQueryHandler
    {
        private readonly ProductContext _Context;

        public GetAllStudentQueryHandler(ProductContext context)
        {
            _Context = context;
        }

        public List<GetAllStudentQuerytResult> Handle() 
        {
            var values = _Context.Students.Select(x => new GetAllStudentQuerytResult
            {

                City = x.City,
                Department = x.Department,
                Name = x.Name,
                StudentID = x.StudentID,
                Surname = x.Surname
            }).AsNoTracking().ToList();

            return values;
        }
    }
}
