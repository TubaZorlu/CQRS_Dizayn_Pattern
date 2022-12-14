using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.DAL.Entities;

namespace UpSchool_CQRS_Projects.DAL.Context
{
    public class ProductContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-CJELTSN\\MSSQLSERVER2019; Database=DbCQRS;integrated security=True;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
