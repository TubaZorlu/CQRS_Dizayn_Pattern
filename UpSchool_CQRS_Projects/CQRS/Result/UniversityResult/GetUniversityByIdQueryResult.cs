using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpSchool_CQRS_Projects.CQRS.Result.UniversityResult
{
    public class GetUniversityByIdQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Population { get; set; }

    }
}
