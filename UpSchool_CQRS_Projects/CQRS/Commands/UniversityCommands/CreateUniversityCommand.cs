using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpSchool_CQRS_Projects.CQRS.Commands.UniversityCommands
{
    public class CreateUniversityCommand :IRequest
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Population { get; set; }
        public int FacultyCount { get; set; }

    }
}
