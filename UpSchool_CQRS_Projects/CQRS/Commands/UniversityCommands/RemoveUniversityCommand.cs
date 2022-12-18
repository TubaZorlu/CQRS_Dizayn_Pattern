using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpSchool_CQRS_Projects.CQRS.Commands.UniversityCommands
{
    public class RemoveUniversityCommand: IRequest
    {
        public int Id { get; set; }

        public RemoveUniversityCommand(int id)
        {
            this.Id = id;
        }
    }
}
