using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebR.Models.Body;

namespace WebR.Models.Context
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<Project> project { get; set; }
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options):base(options)
        {

        }
    }
}
