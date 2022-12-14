using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpSchool_CQRS_Projects.CQRS.Queries.StudentQueries
{
    public class GetStudentByIdQuery
    {
        public int id { get; set; }

        public GetStudentByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
