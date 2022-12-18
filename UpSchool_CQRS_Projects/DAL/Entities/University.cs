using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpSchool_CQRS_Projects.DAL.Entities
{
    public class University
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Population { get; set; }
        public int FacultyCount { get; set; }
        public int DepartmantCount { get; set; }
        public string Country { get; set; }
    }
}
